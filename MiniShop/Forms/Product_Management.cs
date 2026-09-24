using MiniShop.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class Product_Management : Form
    {
        public Product_Management()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Product_Management_Load);
        }

        private void Product_Management_Load(object sender, EventArgs e)
        {
            dgvProducts.CellClick += dgvProducts_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
                    comCategory.SelectedIndex = -1; // Reset selection
                }
                else
                {
                    MessageBox.Show("No categories found in database. Please insert categories into the 'Categories' table first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                    p.Quantity
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
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string query = "INSERT INTO Products (ProductName, CategoryID, Price, Quantity) VALUES (@Name, @CatID, @Price, @Qty)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", txtProductName.Text.Trim()),
                    new SqlParameter("@CatID", Convert.ToInt32(comCategory.SelectedValue)),
                    new SqlParameter("@Price", Convert.ToDecimal(txtPrice.Text.Trim())),
                    new SqlParameter("@Qty", Convert.ToInt32(txtQuantity.Text.Trim()))
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
                // 1. Safely retrieve CategoryID from ComboBox (handles DataRowView edge cases)
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
                         SET ProductName = @Name, CategoryID = @CatID, Price = @Price, Quantity = @Qty 
                         WHERE ProductID = @ID";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@ID", Convert.ToInt32(txtProductID.Text.Trim())),
            new SqlParameter("@Name", txtProductName.Text.Trim()),
            new SqlParameter("@CatID", categoryId),
            new SqlParameter("@Price", Convert.ToDecimal(txtPrice.Text.Trim())),
            new SqlParameter("@Qty", Convert.ToInt32(txtQuantity.Text.Trim()))
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductsFromDatabase(); // Refresh DataGridView
                    ClearInputs();
                }
                else
                {
                    // 2. Alert if SQL executed but matched 0 rows
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
            // 1. Verify a product is actually selected from the table
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

            // 2. Ask for confirmation before deleting
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
                        LoadProductsFromDatabase(); // Refresh table grid
                        ClearInputs();              // Reset all form text boxes
                    }
                    else
                    {
                        MessageBox.Show("Delete failed: Product ID not found in database.", "Delete Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            LoadProductsFromDatabase(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadProductsFromDatabase(); // Load all products when search is empty
            }
            else
            {
                LoadProductsFromDatabase(txtSearch.Text.Trim());
            }
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Prevent execution when clicking headers or empty spaces
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            // 2. Safely populate textboxes (handles null and DBNull)
            txtProductID.Text = row.Cells["Product ID"]?.Value?.ToString() ?? "";
            txtProductName.Text = row.Cells["Product Name"]?.Value?.ToString() ?? "";
            txtPrice.Text = row.Cells["Price"]?.Value?.ToString() ?? "";
            txtQuantity.Text = row.Cells["Quantity"]?.Value?.ToString() ?? "";

            // 3. Safely set ComboBox value
            var categoryIdValue = row.Cells["Category ID"]?.Value;
            if (categoryIdValue != null && categoryIdValue != DBNull.Value)
            {
                comCategory.SelectedValue = Convert.ToInt32(categoryIdValue);
            }
            else
            {
                comCategory.SelectedIndex = -1; // Clear selection if Category ID is null
            }
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
            txtProductName.Focus();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}