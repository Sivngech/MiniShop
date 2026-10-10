using MiniShop.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly string connectionString = @"Server=SIVNGECH\SQLEXPRESS;Database=MiniShopDB;Trusted_Connection=True;";
        private int selectedCustomerID = 0;

        public CustomerForm()
        {
            InitializeComponent();

            // Explicitly attach grid events to ensure clicking selects the ID properly
            dgvCustomers.CellClick += dgvCustomers_CellClick;

            this.Load += CustomerForm_Load;
            cboCustomerType.Items.Clear();
            cboCustomerType.Items.AddRange(new string[] { "Regular", "VIP", "Wholesale", "Member" });
            cboCustomerType.SelectedIndex = 0;
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            dgvCustomers.AutoGenerateColumns = false;
            colCustomerID.DataPropertyName = "CustomerID";
            colCustomerName.DataPropertyName = "Name";
            colPhone.DataPropertyName = "Phone";
            colAddress.DataPropertyName = "Address";
            colCustomerType.DataPropertyName = "CustomerType";
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomersFromDb();
        }

        private void LoadCustomersFromDb(string searchQuery = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT CustomerID, Name, Phone, 
                                            ISNULL(Address, '') AS Address, 
                                            ISNULL(CustomerType, 'Regular') AS CustomerType 
                                     FROM dbo.Customers 
                                     WHERE (@Search = '' 
                                        OR Name LIKE '%' + @Search + '%' 
                                        OR Phone LIKE '%' + @Search + '%' 
                                        OR CustomerType LIKE '%' + @Search + '%')
                                     ORDER BY CustomerID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", searchQuery);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCustomers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Allow clicking header rows without breaking
            if (e.RowIndex < 0 || e.RowIndex >= dgvCustomers.Rows.Count) return;

            DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

            // Extract CustomerID safely
            if (row.Cells["colCustomerID"].Value != null && row.Cells["colCustomerID"].Value != DBNull.Value)
            {
                selectedCustomerID = Convert.ToInt32(row.Cells["colCustomerID"].Value);
            }

            txtName.Text = row.Cells["colCustomerName"].Value?.ToString();
            txtPhone.Text = row.Cells["colPhone"].Value?.ToString();
            txtAddress.Text = row.Cells["colAddress"].Value?.ToString();

            string customerType = row.Cells["colCustomerType"].Value?.ToString();
            if (!string.IsNullOrEmpty(customerType) && cboCustomerType.Items.Contains(customerType))
            {
                cboCustomerType.SelectedItem = customerType;
            }
            else
            {
                cboCustomerType.Text = customerType;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Fallback: If selectedCustomerID wasn't set by click, read it directly from grid selection
            if (selectedCustomerID == 0 && dgvCustomers.SelectedRows.Count > 0)
            {
                var val = dgvCustomers.SelectedRows[0].Cells["colCustomerID"].Value;
                if (val != null && val != DBNull.Value)
                {
                    selectedCustomerID = Convert.ToInt32(val);
                }
            }

            if (selectedCustomerID == 0)
            {
                MessageBox.Show("Please select a customer row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to delete Customer ID {selectedCustomerID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM dbo.Customers WHERE CustomerID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", selectedCustomerID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            LoadCustomersFromDb();
                        }
                        else
                        {
                            MessageBox.Show("Customer record not found or already deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 547) // Foreign key constraint violation
            {
                MessageBox.Show("Cannot delete this customer because they have existing transactions or sales orders recorded in the system.", "Delete Forbidden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO dbo.Customers (Name, Phone, Address, CustomerType) 
                                     VALUES (@Name, @Phone, @Address, @CustomerType)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerType", string.IsNullOrWhiteSpace(cboCustomerType.Text) ? "Regular" : cboCustomerType.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadCustomersFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == 0)
            {
                MessageBox.Show("Please select a customer from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE dbo.Customers 
                                     SET Name = @Name, Phone = @Phone, Address = @Address, CustomerType = @CustomerType 
                                     WHERE CustomerID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", selectedCustomerID);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@CustomerType", string.IsNullOrWhiteSpace(cboCustomerType.Text) ? "Regular" : cboCustomerType.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadCustomersFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomersFromDb(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearForm();
            LoadCustomersFromDb();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            selectedCustomerID = 0;
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            if (cboCustomerType.Items.Count > 0)
                cboCustomerType.SelectedIndex = 0;
            else
                cboCustomerType.SelectedIndex = -1;

            dgvCustomers.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter a Phone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            return true;
        }
    }
}