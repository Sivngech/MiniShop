using MiniShop.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class Product_Management : Form
    {
        private string selectedImagePath = "";

        public Product_Management()
        {
            InitializeComponent();
        }

        private void Product_Management_Load(object sender, EventArgs e)
        {
            // Wire events
            btnBrowseImage.Click += btnBrowseImage_Click;
            btnClear.Click += btnClear_Click;
            btnSearch.Click += btnSearch_Click;

            LoadCategoriesIntoComboBox();
            LoadProductsFromDatabase();
        }

        private void LoadCategoriesIntoComboBox()
        {
            try
            {
                string query = "SELECT CategoryID, CategoryName FROM Categories";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    comCategory.DataSource = dt;
                    comCategory.DisplayMember = "CategoryName";
                    comCategory.ValueMember = "CategoryID";
                    comCategory.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No categories found in database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories dropdown: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductsFromDatabase(string searchQuery = "")
        {
            try
            {
                string query = @"SELECT 
                            p.ProductID AS [Product ID], 
                            p.ProductName AS [Product Name], 
                            p.CategoryID AS [Category ID], 
                            c.CategoryName AS [Category], 
                            p.Price, 
                            p.Quantity,
                            p.ImagePath AS [Image Path]
                        FROM Products p
                        INNER JOIN Categories c ON p.CategoryID = c.CategoryID";

                SqlParameter[] parameters = null;

                if (!string.IsNullOrWhiteSpace(searchQuery))
                {
                    query += " WHERE p.ProductName LIKE @Search OR c.CategoryName LIKE @Search";
                    parameters = new SqlParameter[]
                    {
                new SqlParameter("@Search", "%" + searchQuery.Trim() + "%")
                    };
                }

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                // 1. Add Image DataColumn to DataTable if missing
                if (!dt.Columns.Contains("ProductImage"))
                {
                    dt.Columns.Add("ProductImage", typeof(Bitmap));
                }

                // 2. Load images into the DataTable column
                foreach (DataRow row in dt.Rows)
                {
                    string path = row["Image Path"]?.ToString();
                    if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    {
                        try
                        {
                            using (var tempImg = Image.FromFile(path))
                            {
                                row["ProductImage"] = new Bitmap(tempImg);
                            }
                        }
                        catch
                        {
                            row["ProductImage"] = DBNull.Value;
                        }
                    }
                }

                // Set row height template BEFORE binding
                dgvProducts.RowTemplate.Height = 70;

                // 3. Bind DataTable directly
                dgvProducts.DataSource = dt;

                // 4. Remove leftover manual column if present
                if (dgvProducts.Columns.Contains("Image"))
                {
                    dgvProducts.Columns.Remove("Image");
                }

                // 5. Format and position the bound ProductImage column
                if (dgvProducts.Columns["ProductImage"] is DataGridViewImageColumn imgCol)
                {
                    imgCol.HeaderText = "Image";
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    imgCol.Width = 80;
                    imgCol.DisplayIndex = 0; // Far left
                }

                // Hide raw path column
                if (dgvProducts.Columns["Image Path"] != null)
                {
                    dgvProducts.Columns["Image Path"].Visible = false;
                }

                // 6. Set row height for all loaded rows
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    row.Height = 70;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Product Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    if (pbImage.Image != null)
                    {
                        pbImage.Image.Dispose();
                    }
                    pbImage.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string query = @"INSERT INTO Products (ProductName, CategoryID, Price, Quantity, ImagePath) 
                                 VALUES (@Name, @CatID, @Price, @Qty, @Img)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", txtProductName.Text.Trim()),
                    new SqlParameter("@CatID", Convert.ToInt32(comCategory.SelectedValue)),
                    new SqlParameter("@Price", Convert.ToDecimal(txtPrice.Text.Trim())),
                    new SqlParameter("@Qty", Convert.ToInt32(txtQuantity.Text.Trim())),
                    new SqlParameter("@Img", string.IsNullOrEmpty(selectedImagePath) ? (object)DBNull.Value : selectedImagePath)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductsFromDatabase();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Please select a product from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                int categoryId;
                if (comCategory.SelectedValue is DataRowView drv)
                {
                    categoryId = Convert.ToInt32(drv["CategoryID"]);
                }
                else if (comCategory.SelectedValue != null)
                {
                    categoryId = Convert.ToInt32(comCategory.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"UPDATE Products 
                                 SET ProductName = @Name, 
                                     CategoryID = @CatID, 
                                     Price = @Price, 
                                     Quantity = @Qty, 
                                     ImagePath = @Img 
                                 WHERE ProductID = @ID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", Convert.ToInt32(txtProductID.Text.Trim())),
                    new SqlParameter("@Name", txtProductName.Text.Trim()),
                    new SqlParameter("@CatID", categoryId),
                    new SqlParameter("@Price", Convert.ToDecimal(txtPrice.Text.Trim())),
                    new SqlParameter("@Qty", Convert.ToInt32(txtQuantity.Text.Trim())),
                    new SqlParameter("@Img", string.IsNullOrEmpty(selectedImagePath) ? (object)DBNull.Value : selectedImagePath)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductsFromDatabase();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Update failed: Product ID not found in database.", "Update Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Please select a product from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProductID.Text.Trim(), out int productId))
            {
                MessageBox.Show("Invalid Product ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Product ID {productId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Products WHERE ProductID = @ID";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@ID", productId)
                    };

                    int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductsFromDatabase();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed: Product ID not found in database.", "Delete Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex) when (ex.Number == 547) // Foreign Key Constraint Error
                {
                    // Prompt to force delete linked sales records first
                    DialogResult forceDelete = MessageBox.Show(
                        $"Product ID {productId} has existing sales history in orders.\n\nDo you want to delete its sales details and remove this product?",
                        "Product In Use",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (forceDelete == DialogResult.Yes)
                    {
                        try
                        {
                            // Delete child records from SaleDetails first, then delete the Product
                            string deleteWithCascadeQuery = @"
                        DELETE FROM SaleDetails WHERE ProductID = @ID;
                        DELETE FROM Products WHERE ProductID = @ID;";

                            SqlParameter[] forceParameters = new SqlParameter[]
                            {
                        new SqlParameter("@ID", productId)
                            };

                            DatabaseHelper.ExecuteNonQuery(deleteWithCascadeQuery, forceParameters);

                            MessageBox.Show("Product and associated sales records deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProductsFromDatabase();
                            ClearInputs();
                        }
                        catch (Exception innerEx)
                        {
                            MessageBox.Show("Error force-deleting product: " + innerEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProductsFromDatabase(txtSearch.Text.Trim());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadProductsFromDatabase();
            }
            else
            {
                LoadProductsFromDatabase(txtSearch.Text.Trim());
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            txtProductID.Text = row.Cells["Product ID"]?.Value?.ToString() ?? "";
            txtProductName.Text = row.Cells["Product Name"]?.Value?.ToString() ?? "";
            txtPrice.Text = row.Cells["Price"]?.Value?.ToString() ?? "";
            txtQuantity.Text = row.Cells["Quantity"]?.Value?.ToString() ?? "";

            var categoryIdValue = row.Cells["Category ID"]?.Value;
            if (categoryIdValue != null && categoryIdValue != DBNull.Value)
            {
                comCategory.SelectedValue = Convert.ToInt32(categoryIdValue);
            }
            else
            {
                comCategory.SelectedIndex = -1;
            }

            string imgPath = row.Cells["Image Path"]?.Value?.ToString();
            selectedImagePath = imgPath ?? "";

            if (pbImage.Image != null)
            {
                pbImage.Image.Dispose();
                pbImage.Image = null;
            }

            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
            {
                pbImage.Image = Image.FromFile(imgPath);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            comCategory.SelectedIndex = -1;
            selectedImagePath = "";

            if (pbImage.Image != null)
            {
                pbImage.Image.Dispose();
                pbImage.Image = null;
            }

            txtProductName.Focus();
        }
    }
}