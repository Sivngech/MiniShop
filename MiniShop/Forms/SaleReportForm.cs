using MiniShop.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class SaleReportForm : Form
    {
        public SaleReportForm()
        {
            InitializeComponent();
            this.Load += SaleReportForm_Load;
            this.btnGenerateReport.Click += btnGenerateReport_Click;
        }

        private void SaleReportForm_Load(object sender, EventArgs e)
        {
            // Map dgvDailySummary columns to DataTable columns
            colSummaryDate.DataPropertyName = "SaleDate";
            colSummaryOrders.DataPropertyName = "TotalTransactions";
            colSummaryRevenue.DataPropertyName = "TotalSales";
            colSummaryNetProfit.DataPropertyName = "NetRevenue";

            // Map dgvTopProducts columns to DataTable columns
            colProdName.DataPropertyName = "ProductName";
            colUnitsSold.DataPropertyName = "TotalQuantitySold";
            colProdRevenue.DataPropertyName = "TotalRevenue";

            // Set initial date range (First day of current month to today)
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            // Load initial report data
            LoadReportData();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void LoadReportData()
        {
            try
            {
                SaleReport reportModel = new SaleReport();

                // 1. Fetch data from stored procedures / database
                DataTable dtSummary = reportModel.GetSalesByDateRange(dtpStartDate.Value, dtpEndDate.Value);
                DataTable dtTopProducts = reportModel.GetTopSellingProducts(dtpStartDate.Value, dtpEndDate.Value);

                // 2. Bind data to DataGridViews
                dgvDailySummary.DataSource = dtSummary;
                dgvTopProducts.DataSource = dtTopProducts;

                // 3. Calculate summary metrics from DataTable
                decimal totalSales = 0m;
                decimal totalDiscounts = 0m;
                decimal netRevenue = 0m;
                int totalTransactions = 0;

                foreach (DataRow row in dtSummary.Rows)
                {
                    totalTransactions += row["TotalTransactions"] != DBNull.Value ? Convert.ToInt32(row["TotalTransactions"]) : 0;
                    totalSales += row["TotalSales"] != DBNull.Value ? Convert.ToDecimal(row["TotalSales"]) : 0;
                    totalDiscounts += row["TotalDiscounts"] != DBNull.Value ? Convert.ToDecimal(row["TotalDiscounts"]) : 0;
                    netRevenue += row["NetRevenue"] != DBNull.Value ? Convert.ToDecimal(row["NetRevenue"]) : 0;
                }

                // Average Order Value (AOV)
                decimal avgOrderValue = totalTransactions > 0 ? (netRevenue / totalTransactions) : 0m;

                // 4. Update and render summary cards dynamically
                RenderSummaryCards(netRevenue, totalTransactions, totalDiscounts, avgOrderValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales report: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderSummaryCards(decimal netRevenue, int totalTransactions, decimal totalDiscounts, decimal avgOrderValue)
        {
            ConfigureCardPanel(pnlCardRevenue, lblRevenueIcon, "💲", lblTotalRevenueTitle, "Total Revenue", lblTotalRevenueValue, netRevenue.ToString("C2"));
            ConfigureCardPanel(pnlCardTransactions, lblTransactionIcon, "🛒", lblTotalTransactionsTitle, "Transactions", lblTotalTransactionsValue, totalTransactions.ToString("N0"));
            ConfigureCardPanel(pnlCardDiscounts, lblDiscountIcon, "🏷️", lblTotalDiscountsTitle, "Total Discounts", lblTotalDiscountsValue, totalDiscounts.ToString("C2"));
            ConfigureCardPanel(pnlCardAvgOrder, lblAvgOrderIcon, "📊", lblAvgOrderTitle, "Avg Order Value", lblAvgOrderValue, avgOrderValue.ToString("C2"));
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            // Optional: Auto-refresh data when end date changes
            // LoadReportData();
        }
    }
}