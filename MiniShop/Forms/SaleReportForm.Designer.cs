namespace MiniShop.Forms
{
    partial class SaleReportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tblMainLayout = new TableLayoutPanel();
            pnlHeaderFilters = new Panel();
            lblFromDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblToDate = new Label();
            dtpEndDate = new DateTimePicker();
            btnGenerateReport = new Button();
            tblCardsLayout = new TableLayoutPanel();
            pnlCardRevenue = new Panel();
            pnlCardTransactions = new Panel();
            pnlCardDiscounts = new Panel();
            pnlCardAvgOrder = new Panel();
            lblDailySummaryHeader = new Label();
            dgvDailySummary = new DataGridView();
            colSummaryDate = new DataGridViewTextBoxColumn();
            colSummaryOrders = new DataGridViewTextBoxColumn();
            colSummaryRevenue = new DataGridViewTextBoxColumn();
            colSummaryNetProfit = new DataGridViewTextBoxColumn();
            lblProductsHeader = new Label();
            dgvTopProducts = new DataGridView();
            colProdName = new DataGridViewTextBoxColumn();
            colUnitsSold = new DataGridViewTextBoxColumn();
            colProdRevenue = new DataGridViewTextBoxColumn();
            lblRevenueIcon = new Label();
            lblTotalRevenueTitle = new Label();
            lblTotalRevenueValue = new Label();
            lblTransactionIcon = new Label();
            lblTotalTransactionsTitle = new Label();
            lblTotalTransactionsValue = new Label();
            lblDiscountIcon = new Label();
            lblTotalDiscountsTitle = new Label();
            lblTotalDiscountsValue = new Label();
            lblAvgOrderIcon = new Label();
            lblAvgOrderTitle = new Label();
            lblAvgOrderValue = new Label();
            tblMainLayout.SuspendLayout();
            pnlHeaderFilters.SuspendLayout();
            tblCardsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDailySummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopProducts).BeginInit();
            SuspendLayout();
            // 
            // tblMainLayout
            // 
            tblMainLayout.ColumnCount = 1;
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMainLayout.Controls.Add(pnlHeaderFilters, 0, 0);
            tblMainLayout.Controls.Add(tblCardsLayout, 0, 1);
            tblMainLayout.Controls.Add(lblDailySummaryHeader, 0, 2);
            tblMainLayout.Controls.Add(dgvDailySummary, 0, 3);
            tblMainLayout.Controls.Add(lblProductsHeader, 0, 4);
            tblMainLayout.Controls.Add(dgvTopProducts, 0, 5);
            tblMainLayout.Dock = DockStyle.Fill;
            tblMainLayout.Location = new Point(0, 0);
            tblMainLayout.Name = "tblMainLayout";
            tblMainLayout.Padding = new Padding(20);
            tblMainLayout.RowCount = 6;
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMainLayout.Size = new Size(1200, 780);
            tblMainLayout.TabIndex = 0;
            // 
            // pnlHeaderFilters
            // 
            pnlHeaderFilters.BackColor = Color.White;
            pnlHeaderFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlHeaderFilters.Controls.Add(lblFromDate);
            pnlHeaderFilters.Controls.Add(dtpStartDate);
            pnlHeaderFilters.Controls.Add(lblToDate);
            pnlHeaderFilters.Controls.Add(dtpEndDate);
            pnlHeaderFilters.Controls.Add(btnGenerateReport);
            pnlHeaderFilters.Dock = DockStyle.Fill;
            pnlHeaderFilters.Location = new Point(20, 20);
            pnlHeaderFilters.Margin = new Padding(0, 0, 0, 10);
            pnlHeaderFilters.Name = "pnlHeaderFilters";
            pnlHeaderFilters.Size = new Size(1160, 55);
            pnlHeaderFilters.TabIndex = 0;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFromDate.ForeColor = Color.FromArgb(95, 75, 82);
            lblFromDate.Location = new Point(15, 18);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(87, 20);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "From Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(108, 17);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(130, 27);
            dtpStartDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblToDate.ForeColor = Color.FromArgb(95, 75, 82);
            lblToDate.Location = new Point(240, 18);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(67, 20);
            lblToDate.TabIndex = 2;
            lblToDate.Text = "To Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(329, 17);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(130, 27);
            dtpEndDate.TabIndex = 3;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(216, 67, 114);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(190, 48, 94);
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(487, 12);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(140, 32);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // tblCardsLayout
            // 
            tblCardsLayout.ColumnCount = 4;
            tblCardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardsLayout.Controls.Add(pnlCardRevenue, 0, 0);
            tblCardsLayout.Controls.Add(pnlCardTransactions, 1, 0);
            tblCardsLayout.Controls.Add(pnlCardDiscounts, 2, 0);
            tblCardsLayout.Controls.Add(pnlCardAvgOrder, 3, 0);
            tblCardsLayout.Dock = DockStyle.Fill;
            tblCardsLayout.Location = new Point(20, 85);
            tblCardsLayout.Margin = new Padding(0, 0, 0, 10);
            tblCardsLayout.Name = "tblCardsLayout";
            tblCardsLayout.RowCount = 1;
            tblCardsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCardsLayout.Size = new Size(1160, 95);
            tblCardsLayout.TabIndex = 1;
            // 
            // pnlCardRevenue
            // 
            pnlCardRevenue.Location = new Point(3, 3);
            pnlCardRevenue.Name = "pnlCardRevenue";
            pnlCardRevenue.Size = new Size(200, 89);
            pnlCardRevenue.TabIndex = 0;
            // 
            // pnlCardTransactions
            // 
            pnlCardTransactions.Location = new Point(293, 3);
            pnlCardTransactions.Name = "pnlCardTransactions";
            pnlCardTransactions.Size = new Size(200, 89);
            pnlCardTransactions.TabIndex = 1;
            // 
            // pnlCardDiscounts
            // 
            pnlCardDiscounts.Location = new Point(583, 3);
            pnlCardDiscounts.Name = "pnlCardDiscounts";
            pnlCardDiscounts.Size = new Size(200, 89);
            pnlCardDiscounts.TabIndex = 2;
            // 
            // pnlCardAvgOrder
            // 
            pnlCardAvgOrder.Location = new Point(873, 3);
            pnlCardAvgOrder.Name = "pnlCardAvgOrder";
            pnlCardAvgOrder.Size = new Size(200, 89);
            pnlCardAvgOrder.TabIndex = 3;
            // 
            // lblDailySummaryHeader
            // 
            lblDailySummaryHeader.AutoSize = true;
            lblDailySummaryHeader.Dock = DockStyle.Fill;
            lblDailySummaryHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDailySummaryHeader.ForeColor = Color.FromArgb(75, 55, 63);
            lblDailySummaryHeader.Location = new Point(23, 190);
            lblDailySummaryHeader.Name = "lblDailySummaryHeader";
            lblDailySummaryHeader.Size = new Size(1154, 35);
            lblDailySummaryHeader.TabIndex = 2;
            lblDailySummaryHeader.Text = "Sales Summary by Date";
            lblDailySummaryHeader.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dgvDailySummary
            // 
            dgvDailySummary.AllowUserToAddRows = false;
            dgvDailySummary.AllowUserToDeleteRows = false;
            dgvDailySummary.AllowUserToResizeRows = false;
            dgvDailySummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDailySummary.BackgroundColor = Color.White;
            dgvDailySummary.BorderStyle = BorderStyle.None;
            dgvDailySummary.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDailySummary.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(216, 67, 114);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(216, 67, 114);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDailySummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDailySummary.ColumnHeadersHeight = 36;
            dgvDailySummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDailySummary.Columns.AddRange(new DataGridViewColumn[] { colSummaryDate, colSummaryOrders, colSummaryRevenue, colSummaryNetProfit });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(60, 45, 50);
            dataGridViewCellStyle6.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 226, 236);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(80, 55, 65);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDailySummary.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDailySummary.Dock = DockStyle.Fill;
            dgvDailySummary.EnableHeadersVisualStyles = false;
            dgvDailySummary.GridColor = Color.FromArgb(245, 220, 228);
            dgvDailySummary.Location = new Point(20, 230);
            dgvDailySummary.Margin = new Padding(0, 5, 0, 10);
            dgvDailySummary.Name = "dgvDailySummary";
            dgvDailySummary.ReadOnly = true;
            dgvDailySummary.RowHeadersVisible = false;
            dgvDailySummary.RowHeadersWidth = 51;
            dgvDailySummary.RowTemplate.Height = 32;
            dgvDailySummary.Size = new Size(1160, 235);
            dgvDailySummary.TabIndex = 3;
            // 
            // colSummaryDate
            // 
            colSummaryDate.HeaderText = "Date";
            colSummaryDate.MinimumWidth = 6;
            colSummaryDate.Name = "colSummaryDate";
            colSummaryDate.ReadOnly = true;
            // 
            // colSummaryOrders
            // 
            colSummaryOrders.HeaderText = "Total Orders";
            colSummaryOrders.MinimumWidth = 6;
            colSummaryOrders.Name = "colSummaryOrders";
            colSummaryOrders.ReadOnly = true;
            // 
            // colSummaryRevenue
            // 
            colSummaryRevenue.HeaderText = "Total Revenue";
            colSummaryRevenue.MinimumWidth = 6;
            colSummaryRevenue.Name = "colSummaryRevenue";
            colSummaryRevenue.ReadOnly = true;
            // 
            // colSummaryNetProfit
            // 
            colSummaryNetProfit.HeaderText = "Net Profit";
            colSummaryNetProfit.MinimumWidth = 6;
            colSummaryNetProfit.Name = "colSummaryNetProfit";
            colSummaryNetProfit.ReadOnly = true;
            // 
            // lblProductsHeader
            // 
            lblProductsHeader.AutoSize = true;
            lblProductsHeader.Dock = DockStyle.Fill;
            lblProductsHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblProductsHeader.ForeColor = Color.FromArgb(75, 55, 63);
            lblProductsHeader.Location = new Point(23, 475);
            lblProductsHeader.Name = "lblProductsHeader";
            lblProductsHeader.Size = new Size(1154, 35);
            lblProductsHeader.TabIndex = 4;
            lblProductsHeader.Text = "Top 5 Selling Products";
            lblProductsHeader.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dgvTopProducts
            // 
            dgvTopProducts.AllowUserToAddRows = false;
            dgvTopProducts.AllowUserToDeleteRows = false;
            dgvTopProducts.AllowUserToResizeRows = false;
            dgvTopProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopProducts.BackgroundColor = Color.White;
            dgvTopProducts.BorderStyle = BorderStyle.None;
            dgvTopProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTopProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(216, 67, 114);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(216, 67, 114);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvTopProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvTopProducts.ColumnHeadersHeight = 36;
            dgvTopProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTopProducts.Columns.AddRange(new DataGridViewColumn[] { colProdName, colUnitsSold, colProdRevenue });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(60, 45, 50);
            dataGridViewCellStyle8.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 226, 236);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(80, 55, 65);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvTopProducts.DefaultCellStyle = dataGridViewCellStyle8;
            dgvTopProducts.Dock = DockStyle.Fill;
            dgvTopProducts.EnableHeadersVisualStyles = false;
            dgvTopProducts.GridColor = Color.FromArgb(245, 220, 228);
            dgvTopProducts.Location = new Point(20, 515);
            dgvTopProducts.Margin = new Padding(0, 5, 0, 0);
            dgvTopProducts.Name = "dgvTopProducts";
            dgvTopProducts.ReadOnly = true;
            dgvTopProducts.RowHeadersVisible = false;
            dgvTopProducts.RowHeadersWidth = 51;
            dgvTopProducts.RowTemplate.Height = 32;
            dgvTopProducts.Size = new Size(1160, 245);
            dgvTopProducts.TabIndex = 5;
            // 
            // colProdName
            // 
            colProdName.HeaderText = "Product Name";
            colProdName.MinimumWidth = 6;
            colProdName.Name = "colProdName";
            colProdName.ReadOnly = true;
            // 
            // colUnitsSold
            // 
            colUnitsSold.HeaderText = "Units Sold";
            colUnitsSold.MinimumWidth = 6;
            colUnitsSold.Name = "colUnitsSold";
            colUnitsSold.ReadOnly = true;
            // 
            // colProdRevenue
            // 
            colProdRevenue.HeaderText = "Total Revenue Generated";
            colProdRevenue.MinimumWidth = 6;
            colProdRevenue.Name = "colProdRevenue";
            colProdRevenue.ReadOnly = true;
            // 
            // lblRevenueIcon
            // 
            lblRevenueIcon.Location = new Point(0, 0);
            lblRevenueIcon.Name = "lblRevenueIcon";
            lblRevenueIcon.Size = new Size(100, 23);
            lblRevenueIcon.TabIndex = 0;
            // 
            // lblTotalRevenueTitle
            // 
            lblTotalRevenueTitle.Location = new Point(0, 0);
            lblTotalRevenueTitle.Name = "lblTotalRevenueTitle";
            lblTotalRevenueTitle.Size = new Size(100, 23);
            lblTotalRevenueTitle.TabIndex = 0;
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.Location = new Point(0, 0);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new Size(100, 23);
            lblTotalRevenueValue.TabIndex = 0;
            // 
            // lblTransactionIcon
            // 
            lblTransactionIcon.Location = new Point(0, 0);
            lblTransactionIcon.Name = "lblTransactionIcon";
            lblTransactionIcon.Size = new Size(100, 23);
            lblTransactionIcon.TabIndex = 0;
            // 
            // lblTotalTransactionsTitle
            // 
            lblTotalTransactionsTitle.Location = new Point(0, 0);
            lblTotalTransactionsTitle.Name = "lblTotalTransactionsTitle";
            lblTotalTransactionsTitle.Size = new Size(100, 23);
            lblTotalTransactionsTitle.TabIndex = 0;
            // 
            // lblTotalTransactionsValue
            // 
            lblTotalTransactionsValue.Location = new Point(0, 0);
            lblTotalTransactionsValue.Name = "lblTotalTransactionsValue";
            lblTotalTransactionsValue.Size = new Size(100, 23);
            lblTotalTransactionsValue.TabIndex = 0;
            // 
            // lblDiscountIcon
            // 
            lblDiscountIcon.Location = new Point(0, 0);
            lblDiscountIcon.Name = "lblDiscountIcon";
            lblDiscountIcon.Size = new Size(100, 23);
            lblDiscountIcon.TabIndex = 0;
            // 
            // lblTotalDiscountsTitle
            // 
            lblTotalDiscountsTitle.Location = new Point(0, 0);
            lblTotalDiscountsTitle.Name = "lblTotalDiscountsTitle";
            lblTotalDiscountsTitle.Size = new Size(100, 23);
            lblTotalDiscountsTitle.TabIndex = 0;
            // 
            // lblTotalDiscountsValue
            // 
            lblTotalDiscountsValue.Location = new Point(0, 0);
            lblTotalDiscountsValue.Name = "lblTotalDiscountsValue";
            lblTotalDiscountsValue.Size = new Size(100, 23);
            lblTotalDiscountsValue.TabIndex = 0;
            // 
            // lblAvgOrderIcon
            // 
            lblAvgOrderIcon.Location = new Point(0, 0);
            lblAvgOrderIcon.Name = "lblAvgOrderIcon";
            lblAvgOrderIcon.Size = new Size(100, 23);
            lblAvgOrderIcon.TabIndex = 0;
            // 
            // lblAvgOrderTitle
            // 
            lblAvgOrderTitle.Location = new Point(0, 0);
            lblAvgOrderTitle.Name = "lblAvgOrderTitle";
            lblAvgOrderTitle.Size = new Size(100, 23);
            lblAvgOrderTitle.TabIndex = 0;
            // 
            // lblAvgOrderValue
            // 
            lblAvgOrderValue.Location = new Point(0, 0);
            lblAvgOrderValue.Name = "lblAvgOrderValue";
            lblAvgOrderValue.Size = new Size(100, 23);
            lblAvgOrderValue.TabIndex = 0;
            // 
            // SaleReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 247, 250);
            ClientSize = new Size(1200, 780);
            Controls.Add(tblMainLayout);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(60, 45, 50);
            Name = "SaleReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Report";
            WindowState = FormWindowState.Maximized;
            Load += SaleReportForm_Load;
            tblMainLayout.ResumeLayout(false);
            tblMainLayout.PerformLayout();
            pnlHeaderFilters.ResumeLayout(false);
            pnlHeaderFilters.PerformLayout();
            tblCardsLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDailySummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopProducts).EndInit();
            ResumeLayout(false);
        }

        private void ConfigureCardPanel(Panel panel, Label icon, string iconText, Label title, string titleText, Label value, string valueText)
        {
            panel.Controls.Clear();
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Dock = DockStyle.Fill;
            panel.Margin = new Padding(4);

            icon.AutoSize = true;
            icon.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            icon.ForeColor = Color.FromArgb(216, 67, 114);
            icon.Location = new Point(12, 12);
            icon.Text = iconText;

            // Dynamically position title so it never overlaps the icon
            int titleLeftPosition = icon.PreferredWidth + 18;

            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(130, 110, 118);
            title.Location = new Point(titleLeftPosition, 16);
            title.Text = titleText.ToUpper();

            value.AutoSize = true;
            value.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            value.ForeColor = Color.FromArgb(216, 67, 114);
            value.Location = new Point(12, 44);
            value.Text = valueText;

            panel.Controls.Add(icon);
            panel.Controls.Add(title);
            panel.Controls.Add(value);
        }

        #endregion

        private TableLayoutPanel tblMainLayout;
        private Panel pnlHeaderFilters;
        private DateTimePicker dtpEndDate;
        private Label lblToDate;
        private DateTimePicker dtpStartDate;
        private Label lblFromDate;
        private Button btnGenerateReport;

        private TableLayoutPanel tblCardsLayout;
        private Panel pnlCardRevenue;
        private Label lblRevenueIcon;
        private Label lblTotalRevenueValue;
        private Label lblTotalRevenueTitle;

        private Panel pnlCardTransactions;
        private Label lblTransactionIcon;
        private Label lblTotalTransactionsValue;
        private Label lblTotalTransactionsTitle;

        private Panel pnlCardDiscounts;
        private Label lblDiscountIcon;
        private Label lblTotalDiscountsValue;
        private Label lblTotalDiscountsTitle;

        private Panel pnlCardAvgOrder;
        private Label lblAvgOrderIcon;
        private Label lblAvgOrderValue;
        private Label lblAvgOrderTitle;

        private Label lblDailySummaryHeader;
        private DataGridView dgvDailySummary;
        private DataGridViewTextBoxColumn colSummaryDate;
        private DataGridViewTextBoxColumn colSummaryOrders;
        private DataGridViewTextBoxColumn colSummaryRevenue;
        private DataGridViewTextBoxColumn colSummaryNetProfit;

        private Label lblProductsHeader;
        private DataGridView dgvTopProducts;
        private DataGridViewTextBoxColumn colProdName;
        private DataGridViewTextBoxColumn colUnitsSold;
        private DataGridViewTextBoxColumn colProdRevenue;
    }
}