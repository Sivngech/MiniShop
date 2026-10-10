using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MiniShop.Services; // Ensure namespace matches DatabaseHelper

namespace MiniShop.Forms
{
    public partial class SaleHistory : Form
    {
        public SaleHistory()
        {
            InitializeComponent();
        }

        private void SaleHistory_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            // Attach SelectionChanged event handler
            dgvSaleHistory.SelectionChanged -= dgvSaleHistory_SelectionChanged;
            dgvSaleHistory.SelectionChanged += dgvSaleHistory_SelectionChanged;
            btnRefresh.Click -= btnRefresh_Click; 
            btnRefresh.Click += btnRefresh_Click;

            LoadSalesHistory();
        }

        private void LoadSalesHistory()
        {
            // Execute stored procedure using DatabaseHelper
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StartDate", dtpStartDate.Value.Date),
                new SqlParameter("@EndDate", dtpEndDate.Value.Date),
                new SqlParameter("@SearchKeyword",
                    string.IsNullOrWhiteSpace(txtSearch.Text) ? (object)DBNull.Value : txtSearch.Text.Trim())
            };

            // CommandType needs to be specified if calling SP directly via ExecuteQuery,
            // or pass string query:
            string query = "EXEC sp_GetSalesHistory @StartDate, @EndDate, @SearchKeyword";
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dgvSaleHistory.DataSource = dt;

            if (dgvSaleHistory.Columns.Contains("SaleID"))
                dgvSaleHistory.Columns["SaleID"].Visible = false;

            if (dgvSaleHistory.Columns.Contains("NetAmount"))
                dgvSaleHistory.Columns["NetAmount"].Visible = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadSalesHistory();
        }

        private void dgvSaleHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSaleHistory.CurrentRow == null || dgvSaleHistory.CurrentRow.Index < 0)
                return;

            // Check by DataGridView cell name first
            if (dgvSaleHistory.Columns.Contains("SaleID") &&
                dgvSaleHistory.CurrentRow.Cells["SaleID"].Value != DBNull.Value &&
                dgvSaleHistory.CurrentRow.Cells["SaleID"].Value != null)
            {
                if (int.TryParse(dgvSaleHistory.CurrentRow.Cells["SaleID"].Value.ToString(), out int parsedSaleId))
                {
                    LoadSaleDetails(parsedSaleId);
                    return;
                }
            }

            // Fallback: Check underlying DataRowView
            if (dgvSaleHistory.CurrentRow.DataBoundItem is DataRowView rowView &&
                rowView.Row.Table.Columns.Contains("SaleID") &&
                rowView["SaleID"] != DBNull.Value)
            {
                int rowSaleId = Convert.ToInt32(rowView["SaleID"]);
                LoadSaleDetails(rowSaleId);
            }
        }

        private void LoadSaleDetails(int saleId)
        {
            string query = @"
            SELECT 
                P.ProductName, 
                SD.UnitPrice, 
                SD.Quantity, 
                SD.SubTotal 
            FROM SaleDetails SD
            JOIN Products P ON SD.ProductID = P.ProductID
            WHERE SD.SaleID = @SaleID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@SaleID", saleId)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            // Map database column names to pre-defined DataGridView columns
            productName.DataPropertyName = "ProductName";
            unitPrice.DataPropertyName = "UnitPrice";
            quantiy.DataPropertyName = "Quantity";
            subTotal.DataPropertyName = "SubTotal";

            dgvSaleDetails.AutoGenerateColumns = false;
            dgvSaleDetails.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Verify that a row is selected
            if (dgvSaleHistory.CurrentRow == null || dgvSaleHistory.CurrentRow.Index < 0)
            {
                MessageBox.Show("Please select a transaction to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Extract SaleID from the selected row
            int saleId = 0;

            if (dgvSaleHistory.Columns.Contains("SaleID") &&
                dgvSaleHistory.CurrentRow.Cells["SaleID"].Value != null &&
                dgvSaleHistory.CurrentRow.Cells["SaleID"].Value != DBNull.Value)
            {
                int.TryParse(dgvSaleHistory.CurrentRow.Cells["SaleID"].Value.ToString(), out saleId);
            }
            else if (dgvSaleHistory.CurrentRow.DataBoundItem is DataRowView rowView &&
                     rowView.Row.Table.Columns.Contains("SaleID") &&
                     rowView["SaleID"] != DBNull.Value)
            {
                saleId = Convert.ToInt32(rowView["SaleID"]);
            }

            if (saleId <= 0)
            {
                MessageBox.Show("Unable to retrieve Sale ID for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Confirm deletion with the user
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this transaction? Stock quantities will be restored.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            // 4. Delete transaction and restore product stock
            try
            {
                string query = @"
                    BEGIN TRANSACTION;
                    BEGIN TRY
                        -- 1. Restore product inventory stock (change 'Stock' to your actual column name, e.g., Quantity)
                        UPDATE P
                        SET P.Quantity = P.Quantity + SD.Quantity
                        FROM Products P
                        INNER JOIN SaleDetails SD ON P.ProductID = SD.ProductID
                        WHERE SD.SaleID = @SaleID;

                        -- 2. Delete child sale details
                        DELETE FROM SaleDetails WHERE SaleID = @SaleID;

                        -- 3. Delete parent sale record
                        DELETE FROM Sales WHERE SaleID = @SaleID;

                        COMMIT TRANSACTION;
                    END TRY
                    BEGIN CATCH
                        ROLLBACK TRANSACTION;
                        THROW;
                    END CATCH;";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@SaleID", saleId)
                };

                // Execute query via your DatabaseHelper
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Transaction deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Refresh DataGridView and clear details view
                LoadSalesHistory();
                dgvSaleDetails.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // 1. Reset date pickers to current month range
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            // 2. Clear search textbox
            txtSearch.Clear();

            // 3. Clear details grid
            dgvSaleDetails.DataSource = null;

            // 4. Reload data
            LoadSalesHistory();
        }
    }
}