namespace MiniShop.Forms
{
    partial class SaleHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            flowFilters = new FlowLayoutPanel();
            lblFromDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblToDate = new Label();
            dtpEndDate = new DateTimePicker();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnFilter = new Button();
            btnRefresh = new Button();
            lblTitle = new Label();
            panel2 = new Panel();
            tblLayoutMain = new TableLayoutPanel();
            panelGridHeader = new Panel();
            lblGridHeader = new Label();
            btnDelete = new Button();
            dgvSaleHistory = new DataGridView();
            panelDetailHeader = new Panel();
            lblDetailHeader = new Label();
            dgvSaleDetails = new DataGridView();
            productName = new DataGridViewTextBoxColumn();
            unitPrice = new DataGridViewTextBoxColumn();
            quantiy = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            flowFilters.SuspendLayout();
            panel2.SuspendLayout();
            tblLayoutMain.SuspendLayout();
            panelGridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleHistory).BeginInit();
            panelDetailHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 240, 245);
            panel1.Controls.Add(flowFilters);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 95);
            panel1.TabIndex = 0;
            // 
            // flowFilters
            // 
            flowFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowFilters.Controls.Add(lblFromDate);
            flowFilters.Controls.Add(dtpStartDate);
            flowFilters.Controls.Add(lblToDate);
            flowFilters.Controls.Add(dtpEndDate);
            flowFilters.Controls.Add(lblSearch);
            flowFilters.Controls.Add(txtSearch);
            flowFilters.Controls.Add(btnFilter);
            flowFilters.Controls.Add(btnRefresh);
            flowFilters.Location = new Point(16, 50);
            flowFilters.Name = "flowFilters";
            flowFilters.Size = new Size(996, 40);
            flowFilters.TabIndex = 1;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFromDate.ForeColor = Color.FromArgb(60, 60, 60);
            lblFromDate.Location = new Point(0, 6);
            lblFromDate.Margin = new Padding(0, 6, 5, 0);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(93, 21);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "From Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(98, 3);
            dtpStartDate.Margin = new Padding(0, 3, 15, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(130, 27);
            dtpStartDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblToDate.ForeColor = Color.FromArgb(60, 60, 60);
            lblToDate.Location = new Point(243, 6);
            lblToDate.Margin = new Padding(0, 6, 5, 0);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(72, 21);
            lblToDate.TabIndex = 2;
            lblToDate.Text = "To Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(320, 3);
            dtpEndDate.Margin = new Padding(0, 3, 15, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(130, 27);
            dtpEndDate.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(60, 60, 60);
            lblSearch.Location = new Point(465, 6);
            lblSearch.Margin = new Padding(0, 6, 5, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(65, 21);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(535, 3);
            txtSearch.Margin = new Padding(0, 3, 15, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(160, 27);
            txtSearch.TabIndex = 5;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(216, 67, 114);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(710, 1);
            btnFilter.Margin = new Padding(0, 1, 10, 0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 30);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(216, 67, 114);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(216, 67, 114);
            btnRefresh.Location = new Point(795, 1);
            btnRefresh.Margin = new Padding(0, 1, 0, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 30);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Reload";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(216, 67, 114);
            lblTitle.Location = new Point(16, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sales History";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 250, 250);
            panel2.Controls.Add(tblLayoutMain);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 95);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(1028, 497);
            panel2.TabIndex = 1;
            // 
            // tblLayoutMain
            // 
            tblLayoutMain.ColumnCount = 1;
            tblLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayoutMain.Controls.Add(panelGridHeader, 0, 0);
            tblLayoutMain.Controls.Add(dgvSaleHistory, 0, 1);
            tblLayoutMain.Controls.Add(panelDetailHeader, 0, 2);
            tblLayoutMain.Controls.Add(dgvSaleDetails, 0, 3);
            tblLayoutMain.Dock = DockStyle.Fill;
            tblLayoutMain.Location = new Point(15, 15);
            tblLayoutMain.Name = "tblLayoutMain";
            tblLayoutMain.RowCount = 4;
            tblLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayoutMain.Size = new Size(998, 467);
            tblLayoutMain.TabIndex = 0;
            // 
            // panelGridHeader
            // 
            panelGridHeader.Controls.Add(lblGridHeader);
            panelGridHeader.Controls.Add(btnDelete);
            panelGridHeader.Dock = DockStyle.Fill;
            panelGridHeader.Location = new Point(0, 0);
            panelGridHeader.Margin = new Padding(0);
            panelGridHeader.Name = "panelGridHeader";
            panelGridHeader.Size = new Size(998, 40);
            panelGridHeader.TabIndex = 0;
            // 
            // lblGridHeader
            // 
            lblGridHeader.AutoSize = true;
            lblGridHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGridHeader.ForeColor = Color.FromArgb(60, 60, 60);
            lblGridHeader.Location = new Point(0, 5);
            lblGridHeader.Name = "lblGridHeader";
            lblGridHeader.Size = new Size(169, 28);
            lblGridHeader.TabIndex = 0;
            lblGridHeader.Text = "Transactions List";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(838, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 32);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Transaction";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvSaleHistory
            // 
            dgvSaleHistory.AllowUserToAddRows = false;
            dgvSaleHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 245, 248);
            dgvSaleHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSaleHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleHistory.BackgroundColor = Color.White;
            dgvSaleHistory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(216, 67, 114);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(216, 67, 114);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSaleHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSaleHistory.ColumnHeadersHeight = 35;
            dgvSaleHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSaleHistory.Dock = DockStyle.Fill;
            dgvSaleHistory.EnableHeadersVisualStyles = false;
            dgvSaleHistory.Location = new Point(3, 43);
            dgvSaleHistory.MultiSelect = false;
            dgvSaleHistory.Name = "dgvSaleHistory";
            dgvSaleHistory.ReadOnly = true;
            dgvSaleHistory.RowHeadersVisible = false;
            dgvSaleHistory.RowHeadersWidth = 51;
            dgvSaleHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleHistory.Size = new Size(992, 187);
            dgvSaleHistory.TabIndex = 1;
            // 
            // panelDetailHeader
            // 
            panelDetailHeader.Controls.Add(lblDetailHeader);
            panelDetailHeader.Dock = DockStyle.Fill;
            panelDetailHeader.Location = new Point(0, 233);
            panelDetailHeader.Margin = new Padding(0);
            panelDetailHeader.Name = "panelDetailHeader";
            panelDetailHeader.Size = new Size(998, 40);
            panelDetailHeader.TabIndex = 2;
            // 
            // lblDetailHeader
            // 
            lblDetailHeader.AutoSize = true;
            lblDetailHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetailHeader.ForeColor = Color.FromArgb(60, 60, 60);
            lblDetailHeader.Location = new Point(0, 8);
            lblDetailHeader.Name = "lblDetailHeader";
            lblDetailHeader.Size = new Size(201, 28);
            lblDetailHeader.TabIndex = 0;
            lblDetailHeader.Text = "Invoice Items Detail";
            // 
            // dgvSaleDetails
            // 
            dgvSaleDetails.AllowUserToAddRows = false;
            dgvSaleDetails.AllowUserToDeleteRows = false;
            dgvSaleDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleDetails.BackgroundColor = Color.White;
            dgvSaleDetails.BorderStyle = BorderStyle.Fixed3D;
            dgvSaleDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSaleDetails.ColumnHeadersHeight = 35;
            dgvSaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSaleDetails.Columns.AddRange(new DataGridViewColumn[] { productName, unitPrice, quantiy, subTotal });
            dgvSaleDetails.Dock = DockStyle.Fill;
            dgvSaleDetails.EnableHeadersVisualStyles = false;
            dgvSaleDetails.Location = new Point(3, 276);
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.ReadOnly = true;
            dgvSaleDetails.RowHeadersVisible = false;
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleDetails.Size = new Size(992, 188);
            dgvSaleDetails.TabIndex = 3;
            // 
            // productName
            // 
            productName.HeaderText = "Product Name";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // unitPrice
            // 
            unitPrice.HeaderText = "Unit Price";
            unitPrice.MinimumWidth = 6;
            unitPrice.Name = "unitPrice";
            unitPrice.ReadOnly = true;
            // 
            // quantiy
            // 
            quantiy.HeaderText = "Quantity";
            quantiy.MinimumWidth = 6;
            quantiy.Name = "quantiy";
            quantiy.ReadOnly = true;
            // 
            // subTotal
            // 
            subTotal.HeaderText = "SubTotal";
            subTotal.MinimumWidth = 6;
            subTotal.Name = "subTotal";
            subTotal.ReadOnly = true;
            // 
            // SaleHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1028, 592);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SaleHistory";
            Text = "Sale History";
            WindowState = FormWindowState.Maximized;
            Load += SaleHistory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowFilters.ResumeLayout(false);
            flowFilters.PerformLayout();
            panel2.ResumeLayout(false);
            tblLayoutMain.ResumeLayout(false);
            panelGridHeader.ResumeLayout(false);
            panelGridHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleHistory).EndInit();
            panelDetailHeader.ResumeLayout(false);
            panelDetailHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowFilters;
        private Label lblFromDate;
        private Label lblTitle;
        private DateTimePicker dtpStartDate;
        private Label lblToDate;
        private Label lblSearch;
        private DateTimePicker dtpEndDate;
        private Button btnFilter;
        private TextBox txtSearch;
        private Button btnRefresh;

        private Panel panel2;
        private TableLayoutPanel tblLayoutMain;

        private Panel panelGridHeader;
        private Label lblGridHeader;
        private Button btnDelete;

        private DataGridView dgvSaleHistory;

        private Panel panelDetailHeader;
        private Label lblDetailHeader;

        private DataGridView dgvSaleDetails;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn quantiy;
        private DataGridViewTextBoxColumn subTotal;
    }
}