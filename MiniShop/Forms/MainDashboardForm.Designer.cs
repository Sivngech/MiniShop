using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    partial class MainDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboardForm));
            panelSideMenu = new Panel();
            btnSaleReport = new Button();
            btnSale = new Button();
            btnLogout = new Button();
            btnSaleHistory = new Button();
            btnCustomer = new Button();
            btnCategories = new Button();
            BtnProducts = new Button();
            btnDashboard = new Button();
            panelLogo = new Panel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            panelHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblCurrentUser = new Label();
            lblDateTime = new Label();
            pnlHeaderDivider = new Panel();
            panelMainContent = new Panel();
            pnlSummary = new Panel();
            panelCardProducts = new Panel();
            pnlIconProducts = new Panel();
            houseIcon = new PictureBox();
            lblTotalProducts = new Label();
            lblTotalProduct = new Label();
            panelCardCustomers = new Panel();
            pnlIconCustomers = new Panel();
            customerIcon = new PictureBox();
            lblTotalCustomers = new Label();
            lblTotalCustomer = new Label();
            panelCardSales = new Panel();
            pnlIconSales = new Panel();
            revenueIcon = new PictureBox();
            lblTotalSales = new Label();
            lblTotalSale = new Label();
            panelCardRecentSales = new Panel();
            pnlIconRecent = new Panel();
            pictureBox1 = new PictureBox();
            lblRecentTitle = new Label();
            lblsales = new Label();
            pnlRecentCard = new Panel();
            recentTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            invoiceId = new Label();
            lblCustomer = new Label();
            lblDate = new Label();
            lblAmount = new Label();
            lblInvoiceTransaction = new Label();
            lblCustomerTransaction = new Label();
            lblDateTransaction = new Label();
            lblAmountTransaction = new Label();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelHeader.SuspendLayout();
            panelMainContent.SuspendLayout();
            pnlSummary.SuspendLayout();
            panelCardProducts.SuspendLayout();
            pnlIconProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)houseIcon).BeginInit();
            panelCardCustomers.SuspendLayout();
            pnlIconCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerIcon).BeginInit();
            panelCardSales.SuspendLayout();
            pnlIconSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)revenueIcon).BeginInit();
            panelCardRecentSales.SuspendLayout();
            pnlIconRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRecentCard.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.Controls.Add(btnSaleReport);
            panelSideMenu.Controls.Add(btnSale);
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Controls.Add(btnSaleHistory);
            panelSideMenu.Controls.Add(btnCustomer);
            panelSideMenu.Controls.Add(btnCategories);
            panelSideMenu.Controls.Add(BtnProducts);
            panelSideMenu.Controls.Add(btnDashboard);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(220, 665);
            panelSideMenu.TabIndex = 0;
            // 
            // btnSaleReport
            // 
            btnSaleReport.Dock = DockStyle.Top;
            btnSaleReport.Location = new Point(0, 422);
            btnSaleReport.Name = "btnSaleReport";
            btnSaleReport.Size = new Size(220, 46);
            btnSaleReport.TabIndex = 11;
            btnSaleReport.Text = "  💳   Sale Report";
            btnSaleReport.Click += btnSaleReport_Click;
            // 
            // btnSale
            // 
            btnSale.Dock = DockStyle.Top;
            btnSale.Location = new Point(0, 376);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(220, 46);
            btnSale.TabIndex = 10;
            btnSale.Text = "  💳   Sales / POS";
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Location = new Point(0, 615);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 50);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "  ⎋   Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSaleHistory
            // 
            btnSaleHistory.Dock = DockStyle.Top;
            btnSaleHistory.Location = new Point(0, 330);
            btnSaleHistory.Name = "btnSaleHistory";
            btnSaleHistory.Size = new Size(220, 46);
            btnSaleHistory.TabIndex = 2;
            btnSaleHistory.Text = "  📈   Sale History";
            btnSaleHistory.Click += btnSaleHistory_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.Location = new Point(0, 284);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(220, 46);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "  👥   Customers";
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.Location = new Point(0, 238);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(220, 46);
            btnCategories.TabIndex = 4;
            btnCategories.Text = "  🏷️   Categories";
            btnCategories.Click += btnCategories_Click;
            // 
            // BtnProducts
            // 
            BtnProducts.Dock = DockStyle.Top;
            BtnProducts.Location = new Point(0, 192);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(220, 46);
            BtnProducts.TabIndex = 5;
            BtnProducts.Text = "  📦   Products";
            BtnProducts.Click += BtnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(0, 146);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 46);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "  📊   Dashboard";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(picLogo);
            panelLogo.Controls.Add(lblAppName);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 146);
            panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(78, 26);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(76, 76);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.Dock = DockStyle.Bottom;
            lblAppName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAppName.Location = new Point(0, 110);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(220, 36);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "SKINCARE MINI SHOP";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblCurrentUser);
            panelHeader.Controls.Add(lblDateTime);
            panelHeader.Controls.Add(pnlHeaderDivider);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(220, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1177, 72);
            panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(231, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard Overview";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.Location = new Point(25, 40);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(266, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Welcome back, here's today's summary";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Segoe UI", 9.5F);
            lblCurrentUser.Location = new Point(1020, 16);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(95, 21);
            lblCurrentUser.TabIndex = 2;
            lblCurrentUser.Text = "User: Admin";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 9.5F);
            lblDateTime.Location = new Point(1020, 38);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(137, 21);
            lblDateTime.TabIndex = 3;
            lblDateTime.Text = "2026-09-25 15:00";
            // 
            // pnlHeaderDivider
            // 
            pnlHeaderDivider.Dock = DockStyle.Bottom;
            pnlHeaderDivider.Location = new Point(0, 69);
            pnlHeaderDivider.Name = "pnlHeaderDivider";
            pnlHeaderDivider.Size = new Size(1177, 3);
            pnlHeaderDivider.TabIndex = 4;
            // 
            // panelMainContent
            // 
            panelMainContent.Controls.Add(pnlSummary);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(220, 72);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Padding = new Padding(24);
            panelMainContent.Size = new Size(1177, 593);
            panelMainContent.TabIndex = 2;
            // 
            // pnlSummary
            // 
            pnlSummary.Controls.Add(panelCardProducts);
            pnlSummary.Controls.Add(panelCardCustomers);
            pnlSummary.Controls.Add(panelCardSales);
            pnlSummary.Controls.Add(panelCardRecentSales);
            pnlSummary.Controls.Add(pnlRecentCard);
            pnlSummary.Dock = DockStyle.Fill;
            pnlSummary.Location = new Point(24, 24);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(1129, 545);
            pnlSummary.TabIndex = 0;
            // 
            // panelCardProducts
            // 
            panelCardProducts.Controls.Add(pnlIconProducts);
            panelCardProducts.Controls.Add(lblTotalProducts);
            panelCardProducts.Controls.Add(lblTotalProduct);
            panelCardProducts.Location = new Point(0, 0);
            panelCardProducts.Name = "panelCardProducts";
            panelCardProducts.Size = new Size(200, 100);
            panelCardProducts.TabIndex = 0;
            // 
            // pnlIconProducts
            // 
            pnlIconProducts.Controls.Add(houseIcon);
            pnlIconProducts.Location = new Point(0, 0);
            pnlIconProducts.Name = "pnlIconProducts";
            pnlIconProducts.Size = new Size(200, 100);
            pnlIconProducts.TabIndex = 0;
            // 
            // houseIcon
            // 
            houseIcon.Location = new Point(0, 0);
            houseIcon.Name = "houseIcon";
            houseIcon.Size = new Size(100, 50);
            houseIcon.TabIndex = 0;
            houseIcon.TabStop = false;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.Location = new Point(0, 0);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(100, 23);
            lblTotalProducts.TabIndex = 1;
            // 
            // lblTotalProduct
            // 
            lblTotalProduct.Location = new Point(0, 0);
            lblTotalProduct.Name = "lblTotalProduct";
            lblTotalProduct.Size = new Size(100, 23);
            lblTotalProduct.TabIndex = 2;
            // 
            // panelCardCustomers
            // 
            panelCardCustomers.Controls.Add(pnlIconCustomers);
            panelCardCustomers.Controls.Add(lblTotalCustomers);
            panelCardCustomers.Controls.Add(lblTotalCustomer);
            panelCardCustomers.Location = new Point(0, 0);
            panelCardCustomers.Name = "panelCardCustomers";
            panelCardCustomers.Size = new Size(200, 100);
            panelCardCustomers.TabIndex = 1;
            // 
            // pnlIconCustomers
            // 
            pnlIconCustomers.Controls.Add(customerIcon);
            pnlIconCustomers.Location = new Point(0, 0);
            pnlIconCustomers.Name = "pnlIconCustomers";
            pnlIconCustomers.Size = new Size(200, 100);
            pnlIconCustomers.TabIndex = 0;
            // 
            // customerIcon
            // 
            customerIcon.Location = new Point(0, 0);
            customerIcon.Name = "customerIcon";
            customerIcon.Size = new Size(100, 50);
            customerIcon.TabIndex = 0;
            customerIcon.TabStop = false;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.Location = new Point(0, 0);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(100, 23);
            lblTotalCustomers.TabIndex = 1;
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.Location = new Point(0, 0);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(100, 23);
            lblTotalCustomer.TabIndex = 2;
            // 
            // panelCardSales
            // 
            panelCardSales.Controls.Add(pnlIconSales);
            panelCardSales.Controls.Add(lblTotalSales);
            panelCardSales.Controls.Add(lblTotalSale);
            panelCardSales.Location = new Point(0, 0);
            panelCardSales.Name = "panelCardSales";
            panelCardSales.Size = new Size(200, 100);
            panelCardSales.TabIndex = 2;
            // 
            // pnlIconSales
            // 
            pnlIconSales.Controls.Add(revenueIcon);
            pnlIconSales.Location = new Point(0, 0);
            pnlIconSales.Name = "pnlIconSales";
            pnlIconSales.Size = new Size(200, 100);
            pnlIconSales.TabIndex = 0;
            // 
            // revenueIcon
            // 
            revenueIcon.Location = new Point(0, 0);
            revenueIcon.Name = "revenueIcon";
            revenueIcon.Size = new Size(100, 50);
            revenueIcon.TabIndex = 0;
            revenueIcon.TabStop = false;
            // 
            // lblTotalSales
            // 
            lblTotalSales.Location = new Point(0, 0);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(100, 23);
            lblTotalSales.TabIndex = 1;
            // 
            // lblTotalSale
            // 
            lblTotalSale.Location = new Point(0, 0);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(100, 23);
            lblTotalSale.TabIndex = 2;
            // 
            // panelCardRecentSales
            // 
            panelCardRecentSales.Controls.Add(pnlIconRecent);
            panelCardRecentSales.Controls.Add(lblRecentTitle);
            panelCardRecentSales.Controls.Add(lblsales);
            panelCardRecentSales.Location = new Point(0, 0);
            panelCardRecentSales.Name = "panelCardRecentSales";
            panelCardRecentSales.Size = new Size(200, 100);
            panelCardRecentSales.TabIndex = 3;
            // 
            // pnlIconRecent
            // 
            pnlIconRecent.Controls.Add(pictureBox1);
            pnlIconRecent.Location = new Point(0, 0);
            pnlIconRecent.Name = "pnlIconRecent";
            pnlIconRecent.Size = new Size(200, 100);
            pnlIconRecent.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.Location = new Point(0, 0);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(100, 23);
            lblRecentTitle.TabIndex = 1;
            // 
            // lblsales
            // 
            lblsales.Location = new Point(0, 0);
            lblsales.Name = "lblsales";
            lblsales.Size = new Size(100, 23);
            lblsales.TabIndex = 2;
            // 
            // pnlRecentCard
            // 
            pnlRecentCard.Controls.Add(recentTitle);
            pnlRecentCard.Controls.Add(tableLayoutPanel1);
            pnlRecentCard.Location = new Point(0, 0);
            pnlRecentCard.Name = "pnlRecentCard";
            pnlRecentCard.Size = new Size(200, 100);
            pnlRecentCard.TabIndex = 4;
            // 
            // recentTitle
            // 
            recentTitle.AutoSize = true;
            recentTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            recentTitle.Location = new Point(20, 16);
            recentTitle.Name = "recentTitle";
            recentTitle.Size = new Size(188, 25);
            recentTitle.TabIndex = 0;
            recentTitle.Text = "Recent Transactions";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(invoiceId, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCustomer, 1, 0);
            tableLayoutPanel1.Controls.Add(lblDate, 2, 0);
            tableLayoutPanel1.Controls.Add(lblAmount, 3, 0);
            tableLayoutPanel1.Controls.Add(lblInvoiceTransaction, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCustomerTransaction, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDateTransaction, 2, 1);
            tableLayoutPanel1.Controls.Add(lblAmountTransaction, 3, 1);
            tableLayoutPanel1.Location = new Point(20, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // invoiceId
            // 
            invoiceId.Location = new Point(3, 0);
            invoiceId.Name = "invoiceId";
            invoiceId.Size = new Size(44, 23);
            invoiceId.TabIndex = 0;
            invoiceId.Text = "Invoice ID";
            // 
            // lblCustomer
            // 
            lblCustomer.Location = new Point(53, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(44, 23);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer";
            // 
            // lblDate
            // 
            lblDate.Location = new Point(103, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 23);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(153, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(44, 23);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount";
            // 
            // lblInvoiceTransaction
            // 
            lblInvoiceTransaction.Location = new Point(3, 40);
            lblInvoiceTransaction.Name = "lblInvoiceTransaction";
            lblInvoiceTransaction.Size = new Size(44, 23);
            lblInvoiceTransaction.TabIndex = 4;
            lblInvoiceTransaction.Text = "#INV-001";
            lblInvoiceTransaction.Click += lblInvoiceTransaction_Click;
            // 
            // lblCustomerTransaction
            // 
            lblCustomerTransaction.Location = new Point(53, 40);
            lblCustomerTransaction.Name = "lblCustomerTransaction";
            lblCustomerTransaction.Size = new Size(44, 23);
            lblCustomerTransaction.TabIndex = 5;
            lblCustomerTransaction.Text = "Rosa";
            // 
            // lblDateTransaction
            // 
            lblDateTransaction.Location = new Point(103, 40);
            lblDateTransaction.Name = "lblDateTransaction";
            lblDateTransaction.Size = new Size(44, 23);
            lblDateTransaction.TabIndex = 6;
            lblDateTransaction.Text = "24 Sep";
            // 
            // lblAmountTransaction
            // 
            lblAmountTransaction.Location = new Point(153, 40);
            lblAmountTransaction.Name = "lblAmountTransaction";
            lblAmountTransaction.Size = new Size(44, 23);
            lblAmountTransaction.TabIndex = 7;
            lblAmountTransaction.Text = "$25.00";
            // 
            // MainDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 665);
            Controls.Add(panelMainContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSideMenu);
            Name = "MainDashboardForm";
            Text = "MiniShop Dashboard";
            Load += MainDashboardForm_Load;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMainContent.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            panelCardProducts.ResumeLayout(false);
            pnlIconProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)houseIcon).EndInit();
            panelCardCustomers.ResumeLayout(false);
            pnlIconCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerIcon).EndInit();
            panelCardSales.ResumeLayout(false);
            pnlIconSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)revenueIcon).EndInit();
            panelCardRecentSales.ResumeLayout(false);
            pnlIconRecent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRecentCard.ResumeLayout(false);
            pnlRecentCard.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private void SetupCardInnerControls(
            Panel iconBadge,
            PictureBox icon,
            Label lblTitle,
            Label lblVal,
            string titleText,
            string valText)
        {
            // Icon circle
            iconBadge.Size = new Size(40, 40);
            iconBadge.Location = new Point(16, 14);

            // Icon
            icon.Size = new Size(22, 22);
            icon.Location = new Point(9, 9);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.BackColor = Color.Transparent;

            // Title
            lblTitle.Text = titleText;
            lblTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            lblTitle.Location = new Point(16, 62);
            lblTitle.Size = new Size(iconBadge.Parent.Width - 32, 20);
            lblTitle.AutoSize = false;

            // Value
            lblVal.Text = valText;
            lblVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblVal.Location = new Point(16, 82);
            lblVal.Size = new Size(iconBadge.Parent.Width - 32, 30);
            lblVal.AutoSize = false;
        }
        private void SetupDashboardIcons()
        {
            // Products
            houseIcon.Paint -= HouseIcon_Paint;
            houseIcon.Paint += HouseIcon_Paint;

            // Customers
            customerIcon.Paint -= CustomerIcon_Paint;
            customerIcon.Paint += CustomerIcon_Paint;

            // Revenue
            revenueIcon.Paint -= RevenueIcon_Paint;
            revenueIcon.Paint += RevenueIcon_Paint;

            // Today's Sales
            pictureBox1.Paint -= SalesIcon_Paint;
            pictureBox1.Paint += SalesIcon_Paint;
        }
        private void HouseIcon_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using Pen pen = new Pen(Color.FromArgb(235, 87, 137), 2);

            Point[] roof =
            {
                new Point(3, 10),
                new Point(10, 3),
                new Point(17, 10)
            };

            e.Graphics.DrawLines(pen, roof);
            e.Graphics.DrawRectangle(pen, 6, 9, 8, 9);
            e.Graphics.DrawRectangle(pen, 9, 13, 3, 5);
        }

        private void CustomerIcon_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using Pen pen = new Pen(Color.FromArgb(235, 87, 137), 2);

            // First person
            e.Graphics.DrawEllipse(pen, 2, 2, 6, 6);
            e.Graphics.DrawArc(pen, 0, 9, 10, 8, 180, 180);

            // Second person
            e.Graphics.DrawEllipse(pen, 11, 3, 6, 6);
            e.Graphics.DrawArc(pen, 9, 10, 10, 8, 180, 180);
        }

        private void RevenueIcon_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using Pen pen = new Pen(Color.FromArgb(235, 87, 137), 2);

            e.Graphics.DrawLine(pen, 3, 18, 3, 4);
            e.Graphics.DrawLine(pen, 3, 18, 19, 18);

            Point[] line =
            {
                new Point(5, 14),
                new Point(9, 10),
                new Point(13, 12),
                new Point(18, 5)
            };

            e.Graphics.DrawLines(pen, line);
        }

        private void SalesIcon_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using Pen pen = new Pen(Color.FromArgb(235, 87, 137), 2);

            e.Graphics.DrawEllipse(pen, 2, 2, 16, 16);

            e.Graphics.DrawString(
                "$",
                new Font("Segoe UI", 9F, FontStyle.Bold),
                new SolidBrush(Color.FromArgb(235, 87, 137)),
                new PointF(6, 2)
            );
        }
        private void ApplyCustomTheme()
        {
            Color pinkPrimary = Color.FromArgb(235, 87, 137);
            Color pinkPrimaryDark = Color.FromArgb(210, 65, 115);
            Color pinkLightBg = Color.FromArgb(254, 240, 244);
            Color pinkHover = Color.FromArgb(250, 222, 231);
            Color pinkCardBg = Color.FromArgb(255, 248, 250);
            Color pinkBadgeBg = Color.FromArgb(250, 222, 231);
            Color borderSoft = Color.FromArgb(240, 220, 227);
            Color textDark = Color.FromArgb(50, 50, 50);
            Color textMuted = Color.FromArgb(140, 130, 135);

            // Backgrounds
            panelSideMenu.BackColor = pinkLightBg;
            panelLogo.BackColor = pinkLightBg;
            panelHeader.BackColor = Color.White;
            panelMainContent.BackColor = Color.FromArgb(250, 246, 247);
            pnlSummary.BackColor = Color.Transparent;
            pnlHeaderDivider.BackColor = pinkPrimary;

            // Header Texts
            lblAppName.ForeColor = pinkPrimary;
            lblTitle.ForeColor = textDark;
            lblSubtitle.ForeColor = textMuted;
            lblCurrentUser.ForeColor = textDark;
            lblDateTime.ForeColor = textMuted;

            // Navigation Buttons
            Button[] menuBtns = { btnDashboard, BtnProducts, btnCategories, btnCustomer, btnSale, btnSaleHistory, btnSaleReport };
            foreach (var btn in menuBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = pinkHover;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                btn.ForeColor = textDark;
                btn.BackColor = Color.Transparent;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(16, 0, 0, 0);
                btn.Cursor = Cursors.Hand;
            }

            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = pinkHover;
            btnLogout.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            btnLogout.ForeColor = pinkPrimaryDark;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Padding = new Padding(16, 0, 0, 0);
            btnLogout.Cursor = Cursors.Hand;

            // Active Nav State
            SetActiveNavButton(btnDashboard);

            // Cards Styling
            Panel[] cards = { panelCardProducts, panelCardCustomers, panelCardSales, panelCardRecentSales };
            foreach (var card in cards)
            {
                card.BackColor = pinkCardBg;
                card.Paint -= Card_Paint;
                card.Paint += Card_Paint;
            }

            Panel[] badges =
             {
                pnlIconProducts,
                pnlIconCustomers,
                pnlIconSales,
                pnlIconRecent
            };

            foreach (var badge in badges)
            {
                badge.BackColor = pinkBadgeBg;
                badge.Size = new Size(40, 40);
                MakeCircle(badge);
            }

            Label[] cardTitles = { lblTotalProducts, lblTotalCustomers, lblTotalSales, lblRecentTitle };
            foreach (var title in cardTitles) title.ForeColor = textMuted;

            Label[] cardValues = { lblTotalProduct, lblTotalCustomer, lblTotalSale, lblsales };
            foreach (var val in cardValues) val.ForeColor = pinkPrimaryDark;

            // Transactions Table Card
            pnlRecentCard.BackColor = Color.White;
            pnlRecentCard.Paint -= Card_Paint;
            pnlRecentCard.Paint += Card_Paint;

            recentTitle.ForeColor = textDark;

            Label[] tblHeaders = { invoiceId, lblCustomer, lblDate, lblAmount };
            foreach (var h in tblHeaders)
            {
                h.Dock = DockStyle.Fill;
                h.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                h.BackColor = pinkBadgeBg;
                h.ForeColor = pinkPrimaryDark;
                h.TextAlign = ContentAlignment.MiddleCenter;
            }

            Label[] tblRows = { lblInvoiceTransaction, lblCustomerTransaction, lblDateTransaction, lblAmountTransaction };
            Color zebra = Color.FromArgb(253, 247, 249);
            foreach (var r in tblRows)
            {
                r.Dock = DockStyle.Fill;
                r.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                r.BackColor = zebra;
                r.ForeColor = textDark;
                r.TextAlign = ContentAlignment.MiddleCenter;
            }
            lblAmountTransaction.ForeColor = pinkPrimaryDark;

            lblAmount.TextAlign = ContentAlignment.MiddleRight;
            lblAmountTransaction.TextAlign = ContentAlignment.MiddleRight;

            // Resize Bindings
            pnlSummary.Resize -= PnlSummary_Resize;
            pnlSummary.Resize += PnlSummary_Resize;
            LayoutSummaryCards();

            // Setup dashboard cards
            SetupCardInnerControls(
                pnlIconProducts,
                houseIcon,
                lblTotalProducts,
                lblTotalProduct,
                "TOTAL PRODUCTS",
                lblTotalProduct.Text
            );

            SetupCardInnerControls(
                pnlIconCustomers,
                customerIcon,
                lblTotalCustomers,
                lblTotalCustomer,
                "TOTAL CUSTOMERS",
                lblTotalCustomer.Text
            );

            SetupCardInnerControls(
                pnlIconSales,
                revenueIcon,
                lblTotalSales,
                lblTotalSale,
                "TOTAL REVENUE",
                lblTotalSale.Text
            );

            SetupCardInnerControls(
                pnlIconRecent,
                pictureBox1,
                lblRecentTitle,
                lblsales,
                "TODAY'S SALES",
                lblsales.Text
            );

            SetupDashboardIcons();
        }
        private void LayoutSummaryCards()
        {
            if (pnlSummary.Width <= 0) return;

            int gap = 16;
            int cardWidth = Math.Max(140, (pnlSummary.Width - (gap * 3)) / 4);
            int x = 0;

            Panel[] cards = { panelCardProducts, panelCardCustomers, panelCardSales, panelCardRecentSales };
            foreach (var card in cards)
            {
                card.Size = new Size(cardWidth, 125);
                card.Location = new Point(x, 0);
                RoundCorners(card, 12);
                x += cardWidth + gap;
            }

            pnlRecentCard.Location = new Point(0, 141);
            pnlRecentCard.Size = new Size(pnlSummary.Width, Math.Max(260, pnlSummary.Height - 141));
            RoundCorners(pnlRecentCard, 12);

            tableLayoutPanel1.Width = pnlRecentCard.Width - 40;
        }

        private void PnlSummary_Resize(object sender, EventArgs e) => LayoutSummaryCards();

        private static void RoundCorners(Control c, int radius)
        {
            if (c.Width <= 0 || c.Height <= 0) return;
            int d = radius * 2;
            var rect = new Rectangle(0, 0, c.Width, c.Height);
            using var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            c.Region = new Region(path);
        }

        private static void MakeCircle(Control c)
        {
            if (c.Width <= 0 || c.Height <= 0) return;
            using var path = new GraphicsPath();
            path.AddEllipse(0, 0, c.Width, c.Height);
            c.Region = new Region(path);
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            var c = (Control)sender;
            int radius = 12;
            int d = radius * 2;
            var rect = new Rectangle(0, 0, c.Width - 1, c.Height - 1);
            using var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            using var pen = new Pen(Color.FromArgb(240, 220, 227));
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, path);
        }

        // Field Declarations
        private Panel panelSideMenu;
        private Panel panelLogo;
        private PictureBox picLogo;
        private Label lblAppName;
        private Button btnDashboard;
        private Button BtnProducts;
        private Button btnCategories;
        private Button btnCustomer;
        private Button btnSaleHistory;
        private Button btnLogout;

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblCurrentUser;
        private Label lblDateTime;
        private Panel pnlHeaderDivider;

        private Panel panelMainContent;
        private Panel pnlSummary;

        private Panel panelCardProducts;
        private Panel pnlIconProducts;
        private Label lblTotalProducts;
        private Label lblTotalProduct;

        private Panel panelCardCustomers;
        private Panel pnlIconCustomers;
        private Label lblTotalCustomers;
        private Label lblTotalCustomer;

        private Panel panelCardSales;
        private Panel pnlIconSales;
        private Label lblTotalSales;
        private Label lblTotalSale;

        private Panel panelCardRecentSales;
        private Panel pnlIconRecent;
        private Label lblRecentTitle;
        private Label lblsales;

        private Panel pnlRecentCard;
        private Label recentTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label invoiceId;
        private Label lblCustomer;
        private Label lblDate;
        private Label lblAmount;
        private Label lblInvoiceTransaction;
        private Label lblCustomerTransaction;
        private Label lblDateTransaction;
        private Label lblAmountTransaction;

        private PictureBox houseIcon;
        private PictureBox customerIcon;
        private PictureBox revenueIcon;
        private PictureBox pictureBox1;
        private Button btnSale;
        private Button btnSaleReport;
    }
}