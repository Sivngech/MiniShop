using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    partial class MainDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboardForm));
            panelSideMenu = new Panel();
            pbSaleHistory = new PictureBox();
            pbSale = new PictureBox();
            pbCustomer = new PictureBox();
            pbCategory = new PictureBox();
            pbProduct = new PictureBox();
            pbDashboard = new PictureBox();
            btnLogout = new Button();
            btnSaleHistory = new Button();
            btnSale = new Button();
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
            pnlTableHeaderRule = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)pbSaleHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDashboard).BeginInit();
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
            panelSideMenu.Controls.Add(pbSaleHistory);
            panelSideMenu.Controls.Add(pbSale);
            panelSideMenu.Controls.Add(pbCustomer);
            panelSideMenu.Controls.Add(pbCategory);
            panelSideMenu.Controls.Add(pbProduct);
            panelSideMenu.Controls.Add(pbDashboard);
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Controls.Add(btnSaleHistory);
            panelSideMenu.Controls.Add(btnSale);
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
            // pbSaleHistory
            // 
            pbSaleHistory.BackColor = SystemColors.Control;
            pbSaleHistory.Image = (Image)resources.GetObject("pbSaleHistory.Image");
            pbSaleHistory.Location = new Point(16, 333);
            pbSaleHistory.Name = "pbSaleHistory";
            pbSaleHistory.Size = new Size(22, 22);
            pbSaleHistory.SizeMode = PictureBoxSizeMode.Zoom;
            pbSaleHistory.TabIndex = 12;
            pbSaleHistory.TabStop = false;
            // 
            // pbSale
            // 
            pbSale.Image = (Image)resources.GetObject("pbSale.Image");
            pbSale.Location = new Point(16, 287);
            pbSale.Name = "pbSale";
            pbSale.Size = new Size(22, 22);
            pbSale.SizeMode = PictureBoxSizeMode.Zoom;
            pbSale.TabIndex = 11;
            pbSale.TabStop = false;
            // 
            // pbCustomer
            // 
            pbCustomer.Image = (Image)resources.GetObject("pbCustomer.Image");
            pbCustomer.Location = new Point(16, 241);
            pbCustomer.Name = "pbCustomer";
            pbCustomer.Size = new Size(22, 22);
            pbCustomer.SizeMode = PictureBoxSizeMode.Zoom;
            pbCustomer.TabIndex = 10;
            pbCustomer.TabStop = false;
            // 
            // pbCategory
            // 
            pbCategory.Image = (Image)resources.GetObject("pbCategory.Image");
            pbCategory.Location = new Point(16, 195);
            pbCategory.Name = "pbCategory";
            pbCategory.Size = new Size(22, 22);
            pbCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pbCategory.TabIndex = 9;
            pbCategory.TabStop = false;
            // 
            // pbProduct
            // 
            pbProduct.Image = (Image)resources.GetObject("pbProduct.Image");
            pbProduct.Location = new Point(16, 149);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(22, 22);
            pbProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pbProduct.TabIndex = 8;
            pbProduct.TabStop = false;
            // 
            // pbDashboard
            // 
            pbDashboard.Image = (Image)resources.GetObject("pbDashboard.Image");
            pbDashboard.Location = new Point(16, 103);
            pbDashboard.Name = "pbDashboard";
            pbDashboard.Size = new Size(22, 22);
            pbDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pbDashboard.TabIndex = 6;
            pbDashboard.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Location = new Point(0, 615);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(45, 0, 0, 0);
            btnLogout.Size = new Size(220, 50);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "⎋  Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSaleHistory
            // 
            btnSaleHistory.Dock = DockStyle.Top;
            btnSaleHistory.Location = new Point(0, 321);
            btnSaleHistory.Name = "btnSaleHistory";
            btnSaleHistory.Padding = new Padding(45, 0, 0, 0);
            btnSaleHistory.Size = new Size(220, 46);
            btnSaleHistory.TabIndex = 6;
            btnSaleHistory.Text = "Sale History";
            btnSaleHistory.Click += btnSaleHistory_Click;
            // 
            // btnSale
            // 
            btnSale.Dock = DockStyle.Top;
            btnSale.Location = new Point(0, 275);
            btnSale.Name = "btnSale";
            btnSale.Padding = new Padding(45, 0, 0, 0);
            btnSale.Size = new Size(220, 46);
            btnSale.TabIndex = 5;
            btnSale.Text = "Sale / POS";
            btnSale.Click += btnSale_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.Location = new Point(0, 229);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(45, 0, 0, 0);
            btnCustomer.Size = new Size(220, 46);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "Customers";
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.Location = new Point(0, 183);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(45, 0, 0, 0);
            btnCategories.Size = new Size(220, 46);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "Categories";
            btnCategories.Click += btnCategories_Click;
            // 
            // BtnProducts
            // 
            BtnProducts.Dock = DockStyle.Top;
            BtnProducts.Location = new Point(0, 137);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Padding = new Padding(45, 0, 0, 0);
            BtnProducts.Size = new Size(220, 46);
            BtnProducts.TabIndex = 2;
            BtnProducts.Text = "Products";
            BtnProducts.Click += BtnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(0, 91);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(45, 0, 0, 0);
            btnDashboard.Size = new Size(220, 46);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(picLogo);
            panelLogo.Controls.Add(lblAppName);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 91);
            panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(92, 8);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(36, 36);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.Location = new Point(10, 48);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(200, 20);
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
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(28, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(231, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard Overview";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(30, 44);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(266, 20);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Welcome back, here's today's summary";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentUser.Location = new Point(940, 20);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(95, 21);
            lblCurrentUser.TabIndex = 1;
            lblCurrentUser.Text = "User: Admin";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.Location = new Point(940, 42);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(137, 21);
            lblDateTime.TabIndex = 2;
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
            panelMainContent.Padding = new Padding(20);
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
            pnlSummary.Location = new Point(20, 20);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(1137, 553);
            pnlSummary.TabIndex = 0;
            // 
            // panelCardProducts
            // 
            panelCardProducts.Controls.Add(pnlIconProducts);
            panelCardProducts.Controls.Add(lblTotalProducts);
            panelCardProducts.Controls.Add(lblTotalProduct);
            panelCardProducts.Location = new Point(0, 0);
            panelCardProducts.Name = "panelCardProducts";
            panelCardProducts.Size = new Size(265, 130);
            panelCardProducts.TabIndex = 0;
            // 
            // pnlIconProducts
            // 
            pnlIconProducts.Controls.Add(houseIcon);
            pnlIconProducts.Location = new Point(20, 18);
            pnlIconProducts.Name = "pnlIconProducts";
            pnlIconProducts.Size = new Size(44, 44);
            pnlIconProducts.TabIndex = 2;
            // 
            // houseIcon
            // 
            houseIcon.Image = (Image)resources.GetObject("houseIcon.Image");
            houseIcon.Location = new Point(11, 11);
            houseIcon.Name = "houseIcon";
            houseIcon.Size = new Size(22, 22);
            houseIcon.SizeMode = PictureBoxSizeMode.Zoom;
            houseIcon.TabIndex = 0;
            houseIcon.TabStop = false;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalProducts.Location = new Point(20, 70);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(225, 18);
            lblTotalProducts.TabIndex = 0;
            lblTotalProducts.Text = "TOTAL PRODUCTS";
            lblTotalProducts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalProduct
            // 
            lblTotalProduct.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProduct.Location = new Point(20, 88);
            lblTotalProduct.Name = "lblTotalProduct";
            lblTotalProduct.Size = new Size(225, 32);
            lblTotalProduct.TabIndex = 1;
            lblTotalProduct.Text = "0";
            lblTotalProduct.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCardCustomers
            // 
            panelCardCustomers.Controls.Add(pnlIconCustomers);
            panelCardCustomers.Controls.Add(lblTotalCustomers);
            panelCardCustomers.Controls.Add(lblTotalCustomer);
            panelCardCustomers.Location = new Point(280, 0);
            panelCardCustomers.Name = "panelCardCustomers";
            panelCardCustomers.Size = new Size(265, 130);
            panelCardCustomers.TabIndex = 1;
            // 
            // pnlIconCustomers
            // 
            pnlIconCustomers.Controls.Add(customerIcon);
            pnlIconCustomers.Location = new Point(20, 18);
            pnlIconCustomers.Name = "pnlIconCustomers";
            pnlIconCustomers.Size = new Size(44, 44);
            pnlIconCustomers.TabIndex = 3;
            // 
            // customerIcon
            // 
            customerIcon.Image = (Image)resources.GetObject("customerIcon.Image");
            customerIcon.Location = new Point(11, 11);
            customerIcon.Name = "customerIcon";
            customerIcon.Size = new Size(22, 22);
            customerIcon.SizeMode = PictureBoxSizeMode.Zoom;
            customerIcon.TabIndex = 0;
            customerIcon.TabStop = false;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCustomers.Location = new Point(20, 70);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(225, 18);
            lblTotalCustomers.TabIndex = 0;
            lblTotalCustomers.Text = "TOTAL CUSTOMERS";
            lblTotalCustomers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomer.Location = new Point(20, 88);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(225, 32);
            lblTotalCustomer.TabIndex = 1;
            lblTotalCustomer.Text = "0";
            lblTotalCustomer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCardSales
            // 
            panelCardSales.Controls.Add(pnlIconSales);
            panelCardSales.Controls.Add(lblTotalSales);
            panelCardSales.Controls.Add(lblTotalSale);
            panelCardSales.Location = new Point(560, 0);
            panelCardSales.Name = "panelCardSales";
            panelCardSales.Size = new Size(265, 130);
            panelCardSales.TabIndex = 2;
            // 
            // pnlIconSales
            // 
            pnlIconSales.Controls.Add(revenueIcon);
            pnlIconSales.Location = new Point(20, 18);
            pnlIconSales.Name = "pnlIconSales";
            pnlIconSales.Size = new Size(44, 44);
            pnlIconSales.TabIndex = 4;
            // 
            // revenueIcon
            // 
            revenueIcon.Image = (Image)resources.GetObject("revenueIcon.Image");
            revenueIcon.Location = new Point(11, 11);
            revenueIcon.Name = "revenueIcon";
            revenueIcon.Size = new Size(22, 22);
            revenueIcon.SizeMode = PictureBoxSizeMode.Zoom;
            revenueIcon.TabIndex = 0;
            revenueIcon.TabStop = false;
            // 
            // lblTotalSales
            // 
            lblTotalSales.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSales.Location = new Point(20, 70);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(225, 18);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "TOTAL REVENUE";
            lblTotalSales.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalSale
            // 
            lblTotalSale.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSale.Location = new Point(20, 88);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(225, 32);
            lblTotalSale.TabIndex = 1;
            lblTotalSale.Text = "$0.00";
            lblTotalSale.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCardRecentSales
            // 
            panelCardRecentSales.Controls.Add(pnlIconRecent);
            panelCardRecentSales.Controls.Add(lblRecentTitle);
            panelCardRecentSales.Controls.Add(lblsales);
            panelCardRecentSales.Location = new Point(840, 0);
            panelCardRecentSales.Name = "panelCardRecentSales";
            panelCardRecentSales.Size = new Size(265, 130);
            panelCardRecentSales.TabIndex = 3;
            // 
            // pnlIconRecent
            // 
            pnlIconRecent.Controls.Add(pictureBox1);
            pnlIconRecent.Location = new Point(20, 18);
            pnlIconRecent.Name = "pnlIconRecent";
            pnlIconRecent.Size = new Size(44, 44);
            pnlIconRecent.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecentTitle.Location = new Point(20, 70);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(225, 18);
            lblRecentTitle.TabIndex = 0;
            lblRecentTitle.Text = "TODAY'S SALES";
            lblRecentTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblsales
            // 
            lblsales.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsales.Location = new Point(20, 88);
            lblsales.Name = "lblsales";
            lblsales.Size = new Size(225, 32);
            lblsales.TabIndex = 1;
            lblsales.Text = "$0.00";
            lblsales.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlRecentCard
            // 
            pnlRecentCard.Controls.Add(recentTitle);
            pnlRecentCard.Controls.Add(pnlTableHeaderRule);
            pnlRecentCard.Controls.Add(tableLayoutPanel1);
            pnlRecentCard.Location = new Point(0, 150);
            pnlRecentCard.Name = "pnlRecentCard";
            pnlRecentCard.Size = new Size(1105, 380);
            pnlRecentCard.TabIndex = 4;
            // 
            // recentTitle
            // 
            recentTitle.AutoSize = true;
            recentTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recentTitle.Location = new Point(24, 18);
            recentTitle.Name = "recentTitle";
            recentTitle.Size = new Size(188, 25);
            recentTitle.TabIndex = 0;
            recentTitle.Text = "Recent Transactions";
            // 
            // pnlTableHeaderRule
            // 
            pnlTableHeaderRule.Location = new Point(24, 54);
            pnlTableHeaderRule.Name = "pnlTableHeaderRule";
            pnlTableHeaderRule.Size = new Size(1057, 2);
            pnlTableHeaderRule.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
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
            tableLayoutPanel1.Location = new Point(21, 79);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(4, 0, 4, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(1060, 86);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // invoiceId
            // 
            invoiceId.Dock = DockStyle.Fill;
            invoiceId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceId.Location = new Point(9, 2);
            invoiceId.Name = "invoiceId";
            invoiceId.Size = new Size(254, 38);
            invoiceId.TabIndex = 0;
            invoiceId.Text = "Invoice ID";
            invoiceId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            lblCustomer.Dock = DockStyle.Fill;
            lblCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(271, 2);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(254, 38);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer";
            lblCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.Dock = DockStyle.Fill;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(533, 2);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(254, 38);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(795, 2);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(256, 38);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInvoiceTransaction
            // 
            lblInvoiceTransaction.Dock = DockStyle.Fill;
            lblInvoiceTransaction.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceTransaction.Location = new Point(9, 42);
            lblInvoiceTransaction.Name = "lblInvoiceTransaction";
            lblInvoiceTransaction.Size = new Size(254, 42);
            lblInvoiceTransaction.TabIndex = 4;
            lblInvoiceTransaction.Text = "#INV-001";
            lblInvoiceTransaction.TextAlign = ContentAlignment.MiddleCenter;
            lblInvoiceTransaction.Click += lblInvoiceTransaction_Click;
            // 
            // lblCustomerTransaction
            // 
            lblCustomerTransaction.Dock = DockStyle.Fill;
            lblCustomerTransaction.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerTransaction.Location = new Point(271, 42);
            lblCustomerTransaction.Name = "lblCustomerTransaction";
            lblCustomerTransaction.Size = new Size(254, 42);
            lblCustomerTransaction.TabIndex = 5;
            lblCustomerTransaction.Text = "Rosa";
            lblCustomerTransaction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateTransaction
            // 
            lblDateTransaction.Dock = DockStyle.Fill;
            lblDateTransaction.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTransaction.Location = new Point(533, 42);
            lblDateTransaction.Name = "lblDateTransaction";
            lblDateTransaction.Size = new Size(254, 42);
            lblDateTransaction.TabIndex = 6;
            lblDateTransaction.Text = "24 Sep";
            lblDateTransaction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmountTransaction
            // 
            lblAmountTransaction.Dock = DockStyle.Fill;
            lblAmountTransaction.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountTransaction.Location = new Point(795, 42);
            lblAmountTransaction.Name = "lblAmountTransaction";
            lblAmountTransaction.Size = new Size(256, 42);
            lblAmountTransaction.TabIndex = 7;
            lblAmountTransaction.Text = "$25.00";
            lblAmountTransaction.TextAlign = ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)pbSaleHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDashboard).EndInit();
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

        /// <summary>
        /// Applies the pink theme (matching the login screen) to the dashboard layout,
        /// including rounded cards, circular icon badges and hover states.
        /// Call this once, right after InitializeComponent(), e.g. in the form constructor.
        /// </summary>
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

            // ---- Main backgrounds ----
            panelSideMenu.BackColor = pinkLightBg;
            panelLogo.BackColor = pinkLightBg;
            panelHeader.BackColor = Color.White;
            panelMainContent.BackColor = Color.FromArgb(250, 246, 247);
            pnlSummary.BackColor = Color.Transparent;
            pnlHeaderDivider.BackColor = pinkPrimary;

            // ---- Logo / brand ----
            lblAppName.ForeColor = pinkPrimary;
            lblAppName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            //lblAppTagline.ForeColor = textMuted;
            //lblAppTagline.Font = new Font("Segoe UI", 7.5F, FontStyle.Italic);

            // ---- Header text ----
            lblTitle.ForeColor = textDark;
            lblSubtitle.ForeColor = textMuted;
            lblCurrentUser.ForeColor = textDark;
            lblDateTime.ForeColor = textMuted;

            // ---- Sidebar buttons ----
            Button[] menuBtns = { btnDashboard, BtnProducts, btnCategories, btnCustomer, btnSale, btnSaleHistory };
            foreach (var btn in menuBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = pinkHover;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                btn.ForeColor = textDark;
                btn.BackColor = Color.Transparent;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Cursor = Cursors.Hand;
            }

            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = pinkHover;
            btnLogout.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            btnLogout.ForeColor = pinkPrimaryDark;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Cursor = Cursors.Hand;

            // Highlight the active menu button (Dashboard by default)
            SetActiveNavButton(btnDashboard);

            // ---- Summary cards ----
            Panel[] cards = { panelCardProducts, panelCardCustomers, panelCardSales, panelCardRecentSales };
            foreach (var card in cards)
            {
                card.BackColor = pinkCardBg;
                RoundCorners(card, 14);
                card.Paint -= Card_Paint;
                card.Paint += Card_Paint;
            }

            Panel[] badges = { pnlIconProducts, pnlIconCustomers, pnlIconSales, pnlIconRecent };
            foreach (var badge in badges)
            {
                badge.BackColor = pinkBadgeBg;
                MakeCircle(badge);
            }

            Label[] cardTitles = { lblTotalProducts, lblTotalCustomers, lblTotalSales, lblRecentTitle };
            foreach (var title in cardTitles)
            {
                title.ForeColor = textMuted;
            }

            Label[] cardValues = { lblTotalProduct, lblTotalCustomer, lblTotalSale, lblsales };
            foreach (var val in cardValues)
            {
                val.ForeColor = pinkPrimaryDark;
            }

            // ---- Recent transactions card ----
            pnlRecentCard.BackColor = Color.White;
            RoundCorners(pnlRecentCard, 14);
            pnlRecentCard.Paint -= Card_Paint;
            pnlRecentCard.Paint += Card_Paint;

            recentTitle.ForeColor = textDark;
            pnlTableHeaderRule.BackColor = borderSoft;
            tableLayoutPanel1.BackColor = Color.White;

            Label[] tblHeaders = { invoiceId, lblCustomer, lblDate, lblAmount };
            foreach (var h in tblHeaders)
            {
                h.ForeColor = textMuted;
            }

            Label[] tblRows = { lblInvoiceTransaction, lblCustomerTransaction, lblDateTransaction, lblAmountTransaction };
            foreach (var r in tblRows)
            {
                r.ForeColor = textDark;
            }
            lblAmountTransaction.ForeColor = pinkPrimaryDark;

            // Right-align the amount column (numbers read better right-aligned)
            lblAmount.TextAlign = ContentAlignment.MiddleRight;
            lblAmountTransaction.TextAlign = ContentAlignment.MiddleRight;

            // Give the header row a light pink strip so it visually separates from data
            invoiceId.BackColor = pinkBadgeBg;
            lblCustomer.BackColor = pinkBadgeBg;
            lblDate.BackColor = pinkBadgeBg;
            lblAmount.BackColor = pinkBadgeBg;
            foreach (var h in tblHeaders) h.ForeColor = pinkPrimaryDark;

            // Give the data row a very faint tint so it doesn't blend into the white card
            Color zebra = Color.FromArgb(253, 247, 249);
            foreach (var r in tblRows) r.BackColor = zebra;

            // Make cards resize responsively whenever the summary area changes size
            pnlSummary.Resize -= PnlSummary_Resize;
            pnlSummary.Resize += PnlSummary_Resize;
            LayoutSummaryCards();
        }

        /// <summary>Highlights the given sidebar button as the active page and resets the rest.</summary>
        private void SetActiveNavButton(Button active)
        {
            Color pinkPrimary = Color.FromArgb(235, 87, 137);
            Button[] menuBtns = { btnDashboard, BtnProducts, btnCategories, btnCustomer, btnSale, btnSaleHistory };
            foreach (var btn in menuBtns)
            {
                bool isActive = btn == active;
                btn.BackColor = isActive ? pinkPrimary : Color.Transparent;
                btn.ForeColor = isActive ? Color.White : Color.FromArgb(50, 50, 50);
            }
        }

        /// <summary>Keeps the four summary cards and the recent-transactions card evenly spaced as the window resizes.</summary>
        private void LayoutSummaryCards()
        {
            int gap = 20;
            int cardWidth = Math.Max(160, (pnlSummary.Width - gap * 3) / 4);
            int x = 0;
            foreach (var card in new[] { panelCardProducts, panelCardCustomers, panelCardSales, panelCardRecentSales })
            {
                card.Size = new Size(cardWidth, 130);
                card.Location = new Point(x, 0);
                x += cardWidth + gap;
                RoundCorners(card, 14);
            }

            pnlRecentCard.Location = new Point(0, 150);
            pnlRecentCard.Size = new Size(pnlSummary.Width, Math.Max(240, pnlSummary.Height - 150));
            RoundCorners(pnlRecentCard, 14);

            pnlTableHeaderRule.Width = pnlRecentCard.Width - 48;
            tableLayoutPanel1.Width = pnlRecentCard.Width - 48;
        }

        private void PnlSummary_Resize(object sender, EventArgs e) => LayoutSummaryCards();

        /// <summary>Clips a control to a rounded-rectangle region.</summary>
        private static void RoundCorners(Control c, int radius)
        {
            if (c.Width <= 0 || c.Height <= 0) return;
            int d = radius * 2;
            var rect = new Rectangle(0, 0, c.Width, c.Height);
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            c.Region = new Region(path);
        }

        /// <summary>Clips a square control to a perfect circle.</summary>
        private static void MakeCircle(Control c)
        {
            if (c.Width <= 0 || c.Height <= 0) return;
            var path = new GraphicsPath();
            path.AddEllipse(0, 0, c.Width, c.Height);
            c.Region = new Region(path);
        }

        /// <summary>Draws a soft 1px border to match each card's rounded region.</summary>
        private void Card_Paint(object sender, PaintEventArgs e)
        {
            var c = (Control)sender;
            int radius = 14;
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

        private Panel panelSideMenu;
        private Panel panelLogo;
        private PictureBox picLogo;
        private Label lblAppName;
        private Button btnDashboard;
        private Button BtnProducts;
        private Button btnCategories;
        private Button btnCustomer;
        private Button btnSale;
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
        private Panel pnlTableHeaderRule;
        private TableLayoutPanel tableLayoutPanel1;
        private Label invoiceId;
        private Label lblCustomer;
        private Label lblDate;
        private Label lblAmount;
        private Label lblInvoiceTransaction;
        private Label lblCustomerTransaction;
        private Label lblDateTransaction;
        private Label lblAmountTransaction;
        private PictureBox pbSaleHistory;
        private PictureBox pbSale;
        private PictureBox pbCustomer;
        private PictureBox pbCategory;
        private PictureBox pbProduct;
        private PictureBox pbDashboard;
        private PictureBox houseIcon;
        private PictureBox customerIcon;
        private PictureBox revenueIcon;
        private PictureBox pictureBox1;
    }
}