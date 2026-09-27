using MiniShop.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class Category_Management : Form
    {
        private readonly CategoryDAO categoryDAO = new CategoryDAO();

        public Category_Management()
        {
            InitializeComponent();

            // Event bindings
            this.Load += Category_Management_Load;
            dgvCategories.CellClick += dgvCategories_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            btnSearch.Click += btnSearch_Click;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
        }

        private void Category_Management_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
            rbActive.Checked = true;
            LoadCategories();
        }

        // ការរៀបចំ Style របស់ DataGridView ឱ្យស្អាតរៀបរយ
        private void FormatDataGridView()
        {
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.MultiSelect = false;
            dgvCategories.ReadOnly = true;
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.RowHeadersVisible = false;

            // UI Color Polish
            dgvCategories.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = Color.LightPink;
            dgvCategories.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvCategories.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        private void LoadCategories(string searchQuery = "")
        {
            try
            {
                DataTable dt = categoryDAO.GetAllCategories(searchQuery);
                dgvCategories.DataSource = dt;

                // បង្ហាញចំនួន Record សរុប (ប្រសិនបើមាន lblTotal Records)
                // lblTotalCount.Text = $"Total Categories: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCategories.Rows[e.RowIndex];

            txtCategoryID.Text = row.Cells["Category ID"]?.Value?.ToString() ?? "";
            txtCategoryName.Text = row.Cells["Category Name"]?.Value?.ToString() ?? "";
            txtDescription.Text = row.Cells["Description"]?.Value?.ToString() ?? "";

            // កំណត់ RadioButton តាម Status
            var statusVal = row.Cells["Status"]?.Value;
            bool isActive = true;

            if (statusVal != null && statusVal != DBNull.Value)
            {
                if (statusVal is bool b)
                {
                    isActive = b;
                }
                else
                {
                    string strVal = statusVal.ToString();
                    isActive = strVal.Equals("True", StringComparison.OrdinalIgnoreCase)
                            || strVal.Equals("1")
                            || strVal.Equals("Active", StringComparison.OrdinalIgnoreCase);
                }
            }

            rbActive.Checked = isActive;
            rbInactive.Checked = !isActive;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a Category Name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            try
            {
                bool isActive = rbActive.Checked;
                if (categoryDAO.AddCategory(txtCategoryName.Text.Trim(), txtDescription.Text.Trim(), isActive, out string errorMessage))
                {
                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryID.Text))
            {
                MessageBox.Show("Please select a category from the table to update!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Category Name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int categoryId = Convert.ToInt32(txtCategoryID.Text);
                bool isActive = rbActive.Checked;

                if (categoryDAO.UpdateCategory(categoryId, txtCategoryName.Text.Trim(), txtDescription.Text.Trim(), isActive, out string errorMessage))
                {
                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryID.Text))
            {
                MessageBox.Show("Please select a category from the table to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = Convert.ToInt32(txtCategoryID.Text);

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Category ID {categoryId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    if (categoryDAO.DeleteCategory(categoryId, out string errorMessage))
                    {
                        MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategories();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCategories(txtSearch.Text.Trim());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCategories(txtSearch.Text.Trim());
        }

        // ពេលចុច Enter លើ Search Box ឱ្យវាធ្វើការ Search
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtCategoryID.Clear();
            txtCategoryName.Clear();
            txtDescription.Clear();
            txtSearch.Clear();
            rbActive.Checked = true;
            dgvCategories.ClearSelection();
        }
    }
}