using MiniShop.Models;
using MiniShop.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // --- SAVE BUTTON ---
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                // Read Category ID from input; default to 1 if left empty
                int categoryId = int.TryParse(txtCategoryID.Text.Trim(), out int cat) ? cat : 1;

                // Ensure Category exists in Categories table to satisfy FOREIGN KEY constraint
                EnsureCategoryExists(categoryId);

                string query;
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Name", txtProductName.Text.Trim()),
                    new SqlParameter("@CatID", categoryId),
                    new SqlParameter("@Price", decimal.Parse(txtPrice.Text.Trim())),
                    new SqlParameter("@Qty", int.Parse(txtQuantity.Text.Trim()))
                };

                // Check if user entered a custom Product ID
                if (!string.IsNullOrWhiteSpace(txtProductID.Text) && int.TryParse(txtProductID.Text.Trim(), out int customId))
                {
                    query = @"
                        SET IDENTITY_INSERT Products ON;
                        INSERT INTO Products (ProductID, ProductName, CategoryID, Price, Quantity) 
                        VALUES (@ID, @Name, @CatID, @Price, @Qty);
                        SET IDENTITY_INSERT Products OFF;";

                    parameters.Add(new SqlParameter("@ID", customId));
                }
                else
                {
                    query = "INSERT INTO Products (ProductName, CategoryID, Price, Quantity) VALUES (@Name, @CatID, @Price, @Qty);";
                }

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters.ToArray());

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataFromDatabase();
                    ClearInputs();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Primary Key Collision
                {
                    MessageBox.Show($"Product ID {txtProductID.Text.Trim()} already exists. Please use a unique Product ID.", "Duplicate ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- UPDATE BUTTON ---
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || !int.TryParse(txtProductID.Text.Trim(), out int id))
            {
                MessageBox.Show("Please select a product from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                int categoryId = int.TryParse(txtCategoryID.Text.Trim(), out int cat) ? cat : 1;
                EnsureCategoryExists(categoryId);

                string query = "UPDATE Products SET ProductName = @Name, CategoryID = @CatID, Price = @Price, Quantity = @Qty WHERE ProductID = @ID";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", id),
                    new SqlParameter("@Name", txtProductName.Text.Trim()),
                    new SqlParameter("@CatID", categoryId),
                    new SqlParameter("@Price", decimal.Parse(txtPrice.Text.Trim())),
                    new SqlParameter("@Qty", int.Parse(txtQuantity.Text.Trim()))
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataFromDatabase();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- DELETE BUTTON ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductID.Text.Trim(), out int id))
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM Products WHERE ProductID = @ID";
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@ID", id)
                        };

                        int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataFromDatabase();
                            ClearInputs();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a valid product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- DATAGRIDVIEW CELL CLICK ---
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtCategoryID.Text = row.Cells["CategoryID"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        // --- HELPER METHOD: AUTO-CREATE MISSING CATEGORY ---
        private void EnsureCategoryExists(int categoryId)
        {
            string checkQuery = "SELECT COUNT(1) FROM Categories WHERE CategoryID = @CatID";
            SqlParameter[] checkParams = new SqlParameter[] { new SqlParameter("@CatID", categoryId) };

            DataTable resultTable = DatabaseHelper.ExecuteQuery(checkQuery, checkParams);
            int exists = Convert.ToInt32(resultTable.Rows[0][0]);

            if (exists == 0)
            {
                // Enables IDENTITY_INSERT temporarily to create the explicit CategoryID in dbo.Categories
                string insertCategoryQuery = @"
                    SET IDENTITY_INSERT Categories ON;
                    INSERT INTO Categories (CategoryID, CategoryName) VALUES (@CatID, @CatName);
                    SET IDENTITY_INSERT Categories OFF;";

                SqlParameter[] insertParams = new SqlParameter[]
                {
                    new SqlParameter("@CatID", categoryId),
                    new SqlParameter("@CatName", "Category " + categoryId)
                };

                DatabaseHelper.ExecuteNonQuery(insertCategoryQuery, insertParams);
            }
        }

        // --- HELPER METHODS ---
        private void ClearInputs()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtCategoryID.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtProductName.Focus();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a Product Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out _))
            {
                MessageBox.Show("Price must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out _))
            {
                MessageBox.Show("Quantity must be a valid whole number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Product_Management_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            try
            {
                string query = "SELECT ProductID, ProductName, CategoryID, Price, Quantity FROM Products";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadDataFromDatabase(); // Reset grid if search is empty
                return;
            }

            try
            {
                string query = "SELECT ProductID, ProductName, CategoryID, Price, Quantity " +
                               "FROM Products " +
                               "WHERE ProductName LIKE @Search OR CAST(ProductID AS NVARCHAR) = @ExactSearch";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Search", "%" + keyword + "%"),
            new SqlParameter("@ExactSearch", keyword)
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadDataFromDatabase();
            }
        }
    }
}