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
            panelSideMenu = new Panel();
            btnLogout = new Button();
            btnSale = new Button();
            btnCustomer = new Button();
            btnCategories = new Button();
            BtnProducts = new Button();
            btnDashboard = new Button();
            panelLogo = new FlowLayoutPanel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            panelHeader = new FlowLayoutPanel();
            lblTitle = new Label();
            panelMainContent = new Panel();
            panelCardSales = new Panel();
            lblTotalSale = new Label();
            lblTotalSales = new Label();
            panelCardCustomers = new Panel();
            lblTotalCustomer = new Label();
            lblTotalCustomers = new Label();
            panelCardProducts = new Panel();
            lblTotalProduct = new Label();
            lblTotalProducts = new Label();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelHeader.SuspendLayout();
            panelMainContent.SuspendLayout();
            panelCardSales.SuspendLayout();
            panelCardCustomers.SuspendLayout();
            panelCardProducts.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = SystemColors.ControlDarkDark;
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Controls.Add(btnSale);
            panelSideMenu.Controls.Add(btnCustomer);
            panelSideMenu.Controls.Add(btnCategories);
            panelSideMenu.Controls.Add(BtnProducts);
            panelSideMenu.Controls.Add(btnDashboard);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelSideMenu.ForeColor = Color.White;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(200, 450);
            panelSideMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 57, 43);
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 305);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 41);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSale
            // 
            btnSale.Dock = DockStyle.Top;
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSale.ForeColor = Color.White;
            btnSale.Location = new Point(0, 264);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(200, 41);
            btnSale.TabIndex = 3;
            btnSale.Text = "POS / Sale";
            btnSale.TextAlign = ContentAlignment.MiddleLeft;
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Location = new Point(0, 223);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(200, 41);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customers";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Top;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(0, 182);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(200, 41);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // BtnProducts
            // 
            BtnProducts.Dock = DockStyle.Top;
            BtnProducts.FlatStyle = FlatStyle.Flat;
            BtnProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnProducts.ForeColor = Color.White;
            BtnProducts.Location = new Point(0, 141);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(200, 41);
            BtnProducts.TabIndex = 0;
            BtnProducts.Text = "Products";
            BtnProducts.TextAlign = ContentAlignment.MiddleLeft;
            BtnProducts.UseVisualStyleBackColor = true;
            BtnProducts.Click += BtnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 41);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(picLogo);
            panelLogo.Controls.Add(lblAppName);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 100);
            panelLogo.TabIndex = 6;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.miniShopLogo_removebg_preview;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(50, 50);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppName.Location = new Point(59, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(102, 28);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "MiniShop";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(200, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(820, 60);
            panelHeader.TabIndex = 1;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(138, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(244, 246, 249);
            panelMainContent.Controls.Add(panelCardSales);
            panelMainContent.Controls.Add(panelCardCustomers);
            panelMainContent.Controls.Add(panelCardProducts);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(200, 60);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(820, 390);
            panelMainContent.TabIndex = 2;
            panelMainContent.Paint += panelMainContent_Paint;
            // 
            // panelCardSales
            // 
            panelCardSales.BackColor = Color.FromArgb(155, 89, 182);
            panelCardSales.Controls.Add(lblTotalSale);
            panelCardSales.Controls.Add(lblTotalSales);
            panelCardSales.Location = new Point(428, 23);
            panelCardSales.Name = "panelCardSales";
            panelCardSales.Size = new Size(200, 100);
            panelCardSales.TabIndex = 2;
            // 
            // lblTotalSale
            // 
            lblTotalSale.AutoSize = true;
            lblTotalSale.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTotalSale.ForeColor = Color.White;
            lblTotalSale.Location = new Point(88, 52);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(27, 20);
            lblTotalSale.TabIndex = 3;
            lblTotalSale.Text = "$0";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = Color.White;
            lblTotalSales.Location = new Point(33, 10);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(109, 17);
            lblTotalSales.TabIndex = 2;
            lblTotalSales.Text = "TOTAL REVENUE";
            // 
            // panelCardCustomers
            // 
            panelCardCustomers.BackColor = Color.FromArgb(46, 204, 113);
            panelCardCustomers.Controls.Add(lblTotalCustomer);
            panelCardCustomers.Controls.Add(lblTotalCustomers);
            panelCardCustomers.Location = new Point(222, 23);
            panelCardCustomers.Name = "panelCardCustomers";
            panelCardCustomers.Size = new Size(200, 100);
            panelCardCustomers.TabIndex = 1;
            // 
            // lblTotalCustomer
            // 
            lblTotalCustomer.AutoSize = true;
            lblTotalCustomer.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTotalCustomer.ForeColor = Color.White;
            lblTotalCustomer.Location = new Point(82, 55);
            lblTotalCustomer.Name = "lblTotalCustomer";
            lblTotalCustomer.Size = new Size(18, 20);
            lblTotalCustomer.TabIndex = 2;
            lblTotalCustomer.Text = "0";
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomers.ForeColor = Color.White;
            lblTotalCustomers.Location = new Point(40, 10);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(128, 17);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "TOTAL CUSTOMERS";
            // 
            // panelCardProducts
            // 
            panelCardProducts.BackColor = Color.FromArgb(52, 152, 219);
            panelCardProducts.Controls.Add(lblTotalProduct);
            panelCardProducts.Controls.Add(lblTotalProducts);
            panelCardProducts.Location = new Point(16, 23);
            panelCardProducts.Name = "panelCardProducts";
            panelCardProducts.Size = new Size(200, 100);
            panelCardProducts.TabIndex = 0;
            // 
            // lblTotalProduct
            // 
            lblTotalProduct.AutoSize = true;
            lblTotalProduct.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTotalProduct.ForeColor = Color.White;
            lblTotalProduct.Location = new Point(58, 55);
            lblTotalProduct.Name = "lblTotalProduct";
            lblTotalProduct.Size = new Size(18, 20);
            lblTotalProduct.TabIndex = 1;
            lblTotalProduct.Text = "0";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProducts.ForeColor = Color.White;
            lblTotalProducts.Location = new Point(46, 10);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(120, 17);
            lblTotalProducts.TabIndex = 0;
            lblTotalProducts.Text = "TOTAL PRODUCTS";
            // 
            // MainDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 450);
            Controls.Add(panelMainContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSideMenu);
            ForeColor = Color.White;
            Name = "MainDashboardForm";
            Text = "MainDashboardForm";
            Load += MainDashboardForm_Load;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMainContent.ResumeLayout(false);
            panelCardSales.ResumeLayout(false);
            panelCardSales.PerformLayout();
            panelCardCustomers.ResumeLayout(false);
            panelCardCustomers.PerformLayout();
            panelCardProducts.ResumeLayout(false);
            panelCardProducts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button BtnProducts;
        private Button btnSale;
        private Button btnCustomer;
        private Button btnCategories;
        private FlowLayoutPanel panelHeader;
        private Label lblTitle;
        private Panel panelMainContent;
        private Button btnDashboard;
        private Button btnLogout;
        private Panel panelCardCustomers;
        private Panel panelCardProducts;
        private Panel panelCardSales;
        private Label lblTotalProducts;
        private Label lblTotalSales;
        private Label lblTotalCustomers;
        private Label lblTotalProduct;
        private Label lblTotalSale;
        private Label lblTotalCustomer;
        private FlowLayoutPanel panelLogo;
        private PictureBox picLogo;
        private Label lblAppName;
    }
}