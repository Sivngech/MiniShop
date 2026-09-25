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
            btnLogout = new Button();
            btnSaleHistory = new Button();
            btnSale = new Button();
            btnCustomer = new Button();
            btnCategories = new Button();
            BtnProducts = new Button();
            btnDashboard = new Button();
            panelLogo = new FlowLayoutPanel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            panelHeader = new Panel();
            lblTitle = new Label();
            lblCurrentUser = new Label();
            lblDateTime = new Label();
            panelMainContent = new Panel();
            pnlSummary = new Panel();
            panelCardProducts = new Panel();
            lblTotalProducts = new Label();
            lblTotalProduct = new Label();
            panelCardCustomers = new Panel();
            lblTotalCustomers = new Label();
            lblTotalCustomer = new Label();
            panelCardSales = new Panel();
            lblTotalSales = new Label();
            lblTotalSale = new Label();
            panelCardRecentSales = new Panel();
            lblRecentTitle = new Label();
            lblsales = new Label();
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
            pbDashboard = new PictureBox();
            pbProduct = new PictureBox();
            pbCategory = new PictureBox();
            pbCustomer = new PictureBox();
            pbSale = new PictureBox();
            pbSaleHistory = new PictureBox();
            houseIcon = new PictureBox();
            customerIcon = new PictureBox();
            revenueIcon = new PictureBox();
            pictureBox1 = new PictureBox();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelHeader.SuspendLayout();
            panelMainContent.SuspendLayout();
            pnlSummary.SuspendLayout();
            panelCardProducts.SuspendLayout();
            panelCardCustomers.SuspendLayout();
            panelCardSales.SuspendLayout();
            panelCardRecentSales.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSaleHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)houseIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)revenueIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Location = new Point(0, 617);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 48);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "  Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSaleHistory
            // 
            btnSaleHistory.Dock = DockStyle.Top;
            btnSaleHistory.Location = new Point(0, 348);
            btnSaleHistory.Name = "btnSaleHistory";
            btnSaleHistory.Size = new Size(220, 48);
            btnSaleHistory.TabIndex = 6;
            btnSaleHistory.Text = "  Sale History";
            // 
            // btnSale
            // 
            btnSale.Dock = DockStyle.Top;
            btnSale.Location = new Point(0, 300);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(220, 48);
            btnSale.TabIndex = 5;
            btnSale.Text = "  POS / Sale";
            btnSale.Click += btnSale_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.Location = new Point(0, 252);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(220, 48);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "  Customers";
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.Location = new Point(0, 204);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(220, 48);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "  Categories";
            btnCategories.Click += btnCategories_Click;
            // 
            // BtnProducts
            // 
            BtnProducts.Dock = DockStyle.Top;
            BtnProducts.Location = new Point(0, 156);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(220, 48);
            BtnProducts.TabIndex = 2;
            BtnProducts.Text = "  Products";
            BtnProducts.Click += BtnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(0, 108);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 48);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "  Dashboard";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblAppName);
            panelLogo.Controls.Add(picLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(15, 20, 0, 0);
            panelLogo.Size = new Size(220, 108);
            panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(159, 23);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(35, 35);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Location = new Point(18, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(135, 20);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Skincare Mini Shop";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblCurrentUser);
            panelHeader.Controls.Add(lblDateTime);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(220, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1177, 60);
            panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard Overview";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Location = new Point(880, 20);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(89, 20);
            lblCurrentUser.TabIndex = 1;
            lblCurrentUser.Text = "User: Admin";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(1010, 21);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(124, 20);
            lblDateTime.TabIndex = 2;
            lblDateTime.Text = "2026-09-25 15:00";
            // 
            // panelMainContent
            // 
            panelMainContent.Controls.Add(pnlSummary);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(220, 60);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Padding = new Padding(20);
            panelMainContent.Size = new Size(1177, 605);
            panelMainContent.TabIndex = 2;
            // 
            // pnlSummary
            // 
            pnlSummary.Controls.Add(panelCardProducts);
            pnlSummary.Controls.Add(panelCardCustomers);
            pnlSummary.Controls.Add(panelCardSales);
            pnlSummary.Controls.Add(panelCardRecentSales);
            pnlSummary.Controls.Add(recentTitle);
            pnlSummary.Controls.Add(tableLayoutPanel1);
            pnlSummary.Dock = DockStyle.Fill;
            pnlSummary.Location = new Point(20, 20);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(1137, 565);
            pnlSummary.TabIndex = 0;
            // 
            // panelCardProducts
            // 
            panelCardProducts.Controls.Add(houseIcon);
            panelCardProducts.Controls.Add(lblTotalProducts);
            panelCardProducts.Controls.Add(lblTotalProduct);
            panelCardProducts.Location = new Point(0, 10);
            panelCardProducts.Name = "panelCardProducts";
            panelCardProducts.Size = new Size(240, 110);
            panelCardProducts.TabIndex = 0;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.Location = new Point(56, 37);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(150, 20);
            lblTotalProducts.TabIndex = 0;
            lblTotalProducts.Text = "TOTAL PRODUCTS";
            // 
            // lblTotalProduct
            // 
            lblTotalProduct.Location = new Point(77, 66);
            lblTotalProduct.Name = "lblTotalProduct";
            lblTotalProduct.Size = new Size(100, 35);
            lblTotalProduct.TabIndex = 1;
            lblTotalProduct.Text = "0";
            // 
            // panelCardCustomers
            // 
            panelCardCustomers.Controls.Add(customerIcon);
            panelCardCustomers.Controls.Add(lblTotalCustomers);
            panelCardCustomers.Controls.Add(lblTotalCustomer);
            panelCardCustomers.Location = new Point(260, 10);
            panelCardCustomers.Name = "panelCardCustomers";
            panelCardCustomers.Size = new Size(240, 110);
            panelCardCustomers.TabIndex = 1;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.Location = new Point(43, 37);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(150, 20);
            lblTotalCustomers.TabIndex = 0;
            lblTotalCustomers.Text = "TOTAL CUSTOMERS";
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.Location = new Point(53, 66);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(100, 35);
            lblTotalCustomer.TabIndex = 1;
            lblTotalCustomer.Text = "0";
            // 
            // panelCardSales
            // 
            panelCardSales.Controls.Add(revenueIcon);
            panelCardSales.Controls.Add(lblTotalSales);
            panelCardSales.Controls.Add(lblTotalSale);
            panelCardSales.Location = new Point(520, 10);
            panelCardSales.Name = "panelCardSales";
            panelCardSales.Size = new Size(240, 110);
            panelCardSales.TabIndex = 2;
            // 
            // lblTotalSales
            // 
            lblTotalSales.Location = new Point(27, 37);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(150, 20);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "TOTAL REVENUE";
            // 
            // lblTotalSale
            // 
            lblTotalSale.Location = new Point(45, 66);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(120, 35);
            lblTotalSale.TabIndex = 1;
            lblTotalSale.Text = "$0.00";
            // 
            // panelCardRecentSales
            // 
            panelCardRecentSales.Controls.Add(pictureBox1);
            panelCardRecentSales.Controls.Add(lblRecentTitle);
            panelCardRecentSales.Controls.Add(lblsales);
            panelCardRecentSales.Location = new Point(780, 10);
            panelCardRecentSales.Name = "panelCardRecentSales";
            panelCardRecentSales.Size = new Size(240, 110);
            panelCardRecentSales.TabIndex = 3;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.Location = new Point(19, 46);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(150, 20);
            lblRecentTitle.TabIndex = 0;
            lblRecentTitle.Text = "TODAY'S SALES";
            // 
            // lblsales
            // 
            lblsales.Location = new Point(45, 66);
            lblsales.Name = "lblsales";
            lblsales.Size = new Size(120, 35);
            lblsales.TabIndex = 1;
            lblsales.Text = "$0.00";
            // 
            // recentTitle
            // 
            recentTitle.AutoSize = true;
            recentTitle.Location = new Point(0, 150);
            recentTitle.Name = "recentTitle";
            recentTitle.Size = new Size(139, 20);
            recentTitle.TabIndex = 4;
            recentTitle.Text = "Recent Transactions";
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel1.Location = new Point(0, 190);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(1020, 80);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // invoiceId
            // 
            invoiceId.Dock = DockStyle.Fill;
            invoiceId.Location = new Point(3, 0);
            invoiceId.Name = "invoiceId";
            invoiceId.Size = new Size(249, 40);
            invoiceId.TabIndex = 0;
            invoiceId.Text = "Invoice ID";
            // 
            // lblCustomer
            // 
            lblCustomer.Dock = DockStyle.Fill;
            lblCustomer.Location = new Point(258, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(249, 40);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer";
            // 
            // lblDate
            // 
            lblDate.Dock = DockStyle.Fill;
            lblDate.Location = new Point(513, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(249, 40);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // lblAmount
            // 
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.Location = new Point(768, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(249, 40);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount";
            // 
            // lblInvoiceTransaction
            // 
            lblInvoiceTransaction.Dock = DockStyle.Fill;
            lblInvoiceTransaction.Location = new Point(3, 40);
            lblInvoiceTransaction.Name = "lblInvoiceTransaction";
            lblInvoiceTransaction.Size = new Size(249, 40);
            lblInvoiceTransaction.TabIndex = 4;
            lblInvoiceTransaction.Text = "#INV-001";
            // 
            // lblCustomerTransaction
            // 
            lblCustomerTransaction.Dock = DockStyle.Fill;
            lblCustomerTransaction.Location = new Point(258, 40);
            lblCustomerTransaction.Name = "lblCustomerTransaction";
            lblCustomerTransaction.Size = new Size(249, 40);
            lblCustomerTransaction.TabIndex = 5;
            lblCustomerTransaction.Text = "Rosa";
            // 
            // lblDateTransaction
            // 
            lblDateTransaction.Dock = DockStyle.Fill;
            lblDateTransaction.Location = new Point(513, 40);
            lblDateTransaction.Name = "lblDateTransaction";
            lblDateTransaction.Size = new Size(249, 40);
            lblDateTransaction.TabIndex = 6;
            lblDateTransaction.Text = "24 Sep";
            // 
            // lblAmountTransaction
            // 
            lblAmountTransaction.Dock = DockStyle.Fill;
            lblAmountTransaction.Location = new Point(768, 40);
            lblAmountTransaction.Name = "lblAmountTransaction";
            lblAmountTransaction.Size = new Size(249, 40);
            lblAmountTransaction.TabIndex = 7;
            lblAmountTransaction.Text = "$25.00";
            // 
            // pbDashboard
            // 
            pbDashboard.Image = (Image)resources.GetObject("pbDashboard.Image");
            pbDashboard.Location = new Point(18, 114);
            pbDashboard.Name = "pbDashboard";
            pbDashboard.Size = new Size(45, 33);
            pbDashboard.TabIndex = 6;
            pbDashboard.TabStop = false;
            // 
            // pbProduct
            // 
            pbProduct.Image = (Image)resources.GetObject("pbProduct.Image");
            pbProduct.Location = new Point(18, 165);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(45, 33);
            pbProduct.TabIndex = 8;
            pbProduct.TabStop = false;
            // 
            // pbCategory
            // 
            pbCategory.Image = (Image)resources.GetObject("pbCategory.Image");
            pbCategory.Location = new Point(18, 217);
            pbCategory.Name = "pbCategory";
            pbCategory.Size = new Size(45, 33);
            pbCategory.TabIndex = 9;
            pbCategory.TabStop = false;
            // 
            // pbCustomer
            // 
            pbCustomer.Image = (Image)resources.GetObject("pbCustomer.Image");
            pbCustomer.Location = new Point(18, 256);
            pbCustomer.Name = "pbCustomer";
            pbCustomer.Size = new Size(45, 33);
            pbCustomer.TabIndex = 10;
            pbCustomer.TabStop = false;
            // 
            // pbSale
            // 
            pbSale.Image = (Image)resources.GetObject("pbSale.Image");
            pbSale.Location = new Point(18, 309);
            pbSale.Name = "pbSale";
            pbSale.Size = new Size(45, 33);
            pbSale.TabIndex = 11;
            pbSale.TabStop = false;
            // 
            // pbSaleHistory
            // 
            pbSaleHistory.Image = (Image)resources.GetObject("pbSaleHistory.Image");
            pbSaleHistory.Location = new Point(18, 354);
            pbSaleHistory.Name = "pbSaleHistory";
            pbSaleHistory.Size = new Size(45, 33);
            pbSaleHistory.TabIndex = 12;
            pbSaleHistory.TabStop = false;
            // 
            // houseIcon
            // 
            houseIcon.Image = (Image)resources.GetObject("houseIcon.Image");
            houseIcon.Location = new Point(77, 0);
            houseIcon.Name = "houseIcon";
            houseIcon.Size = new Size(62, 31);
            houseIcon.TabIndex = 2;
            houseIcon.TabStop = false;
            // 
            // customerIcon
            // 
            customerIcon.Image = (Image)resources.GetObject("customerIcon.Image");
            customerIcon.Location = new Point(73, 0);
            customerIcon.Name = "customerIcon";
            customerIcon.Size = new Size(62, 31);
            customerIcon.TabIndex = 3;
            customerIcon.TabStop = false;
            // 
            // revenueIcon
            // 
            revenueIcon.Image = (Image)resources.GetObject("revenueIcon.Image");
            revenueIcon.Location = new Point(45, 9);
            revenueIcon.Name = "revenueIcon";
            revenueIcon.Size = new Size(62, 31);
            revenueIcon.TabIndex = 4;
            revenueIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 31);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMainContent.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            panelCardProducts.ResumeLayout(false);
            panelCardCustomers.ResumeLayout(false);
            panelCardSales.ResumeLayout(false);
            panelCardRecentSales.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSaleHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)houseIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)revenueIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// Styles the form with modern pink theme at runtime so the WinForms Designer doesn't crash.
        /// </summary>
        private void ApplyCustomTheme()
        {
            Color primaryPink = Color.FromArgb(219, 68, 85);
            Color darkPink = Color.FromArgb(180, 45, 62);
            Color lightBg = Color.FromArgb(253, 246, 248);

            panelSideMenu.BackColor = darkPink;
            panelLogo.BackColor = darkPink;
            panelHeader.BackColor = Color.White;
            panelMainContent.BackColor = lightBg;

            lblAppName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;

            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCurrentUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCurrentUser.ForeColor = primaryPink;

            Button[] menuBtns = { btnDashboard, BtnProducts, btnCategories, btnCustomer, btnSale, btnSaleHistory, btnLogout };
            foreach (var btn in menuBtns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.TextAlign = ContentAlignment.MiddleLeft;
            }
            btnLogout.BackColor = Color.FromArgb(140, 30, 45);

            Panel[] cards = { panelCardProducts, panelCardCustomers, panelCardSales, panelCardRecentSales };
            foreach (var card in cards)
            {
                card.BackColor = Color.White;
            }

            Label[] cardTitles = { lblTotalProducts, lblTotalCustomers, lblTotalSales, lblRecentTitle };
            foreach (var lbl in cardTitles)
            {
                lbl.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                lbl.ForeColor = Color.Gray;
            }

            Label[] cardValues = { lblTotalProduct, lblTotalCustomer, lblTotalSale, lblsales };
            foreach (var lbl in cardValues)
            {
                lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
                lbl.ForeColor = primaryPink;
            }

            recentTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tableLayoutPanel1.BackColor = Color.White;

            Label[] tblHeaders = { invoiceId, lblCustomer, lblDate, lblAmount };
            foreach (var h in tblHeaders)
            {
                h.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                h.ForeColor = primaryPink;
                h.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private Panel panelSideMenu;
        private FlowLayoutPanel panelLogo;
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
        private Label lblCurrentUser;
        private Label lblDateTime;

        private Panel panelMainContent;
        private Panel pnlSummary;

        private Panel panelCardProducts;
        private Label lblTotalProducts;
        private Label lblTotalProduct;

        private Panel panelCardCustomers;
        private Label lblTotalCustomers;
        private Label lblTotalCustomer;

        private Panel panelCardSales;
        private Label lblTotalSales;
        private Label lblTotalSale;

        private Panel panelCardRecentSales;
        private Label lblRecentTitle;
        private Label lblsales;

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