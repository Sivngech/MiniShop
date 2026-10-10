using MiniShop.Models;
using MiniShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class MainDashboardForm : Form
    {
        private Form? activeForm = null;
        private LoginForm? _loginForm;
        private System.Windows.Forms.Timer? _clockTimer;
        public MainDashboardForm(LoginForm loginForm) : this()
        {
            //InitializeComponent();
            //ApplyCustomTheme();
            _loginForm = loginForm;
        }
        public MainDashboardForm()
        {
            InitializeComponent();
            ApplyCustomTheme();

            // Set up active live timer for date & time display in header
            _clockTimer = new System.Windows.Forms.Timer();
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += (s, e) => lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _clockTimer.Start();

            // Register event handlers for navigation buttons
            btnDashboard.Click += btnDashboard_Click;
            BtnProducts.Click += BtnProducts_Click;
            btnCategories.Click += btnCategories_Click;
            btnCustomer.Click += btnCustomer_Click;
            btnSale.Click += btnSale_Click;
            btnSaleHistory.Click += btnSaleHistory_Click;
            btnSaleReport.Click += btnSaleReport_Click;
            btnLogout.Click += btnLogout_Click;
        }
        private void SetActiveNavButton(Button active)
        {
            Color pinkPrimary = Color.FromArgb(235, 87, 137);
            Color sidebarBg = panelSideMenu.BackColor; // Standard background color of panelSideMenu

            Button[] menuBtns = { btnDashboard, BtnProducts, btnCategories, btnCustomer, btnSale, btnSaleHistory, btnSaleReport };

            foreach (var btn in menuBtns)
            {
                if (btn == null) continue;
                bool isActive = (btn == active);
                btn.BackColor = isActive ? pinkPrimary : sidebarBg;
                btn.ForeColor = isActive ? Color.White : Color.FromArgb(50, 50, 50);
                btn.FlatAppearance.MouseOverBackColor = isActive ? pinkPrimary : Color.FromArgb(245, 230, 238);
            }
        }
        private void OpenChildForm(Form childForm, string title, Button activeNavButton)
        {
            // Close current active child form if exists
            if (activeForm != null)
            {
                activeForm.Close();
            }
            panelMainContent.Controls.Clear(); // Clear any existing controls in the main content panel

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Hide summary panel and send it to back
            pnlSummary.Visible = false;
            pnlSummary.SendToBack();

            // Add and show child form inside container
            panelMainContent.Controls.Add(childForm);
            panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = title;
            SetActiveNavButton(activeNavButton);
        }
        private void SwitchToDashboardView()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            panelMainContent.Controls.Clear(); // Clear any existing controls in the main content panel
            pnlSummary.Visible = true;
            pnlSummary.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(pnlSummary);
            pnlSummary.BringToFront();
            lblTitle.Text = "Dashboard Overview";
            SetActiveNavButton(btnDashboard);
            LoadDashboardSummary();
        }
        private void BtnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product_Management(), "Product Management", BtnProducts);
            SetActiveNavButton(BtnProducts);

        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Category_Management(), "Category Management", btnCategories);
            SetActiveNavButton(btnCategories);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm(), "Customer Management", btnCustomer);
            SetActiveNavButton(btnCustomer);
        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
            if (User.CurrentUser != null)
            {
                lblCurrentUser.Text = $"User: {User.CurrentUser.Username}";
            }
            LoadDashboardSummary();
            SetActiveNavButton(btnDashboard);
        }
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new pos_sale(), "Sales / POS Management", btnSale);
            SetActiveNavButton(btnSale);
        }
        private void LoadDashboardSummary()
        {
            try
            {
                // 1. Fetch Summary Card Metrics
                object countProducts = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Products") ?? 0;
                object countCustomers = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Customers") ?? 0;
                object totalRevenue = DatabaseHelper.ExecuteScalar("SELECT ISNULL(SUM(TotalAmount), 0) FROM Sales") ?? 0;

                // Fetch Today's Sales (Filtered by current date)
                string todaysSalesQuery = "SELECT ISNULL(SUM(TotalAmount), 0) FROM Sales WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)";
                object todaySales = DatabaseHelper.ExecuteScalar(todaysSalesQuery) ?? 0;

                // Assign Values to Summary Labels
                lblTotalProduct.Text = countProducts.ToString();
                lblTotalCustomer.Text = countCustomers.ToString();
                lblTotalSale.Text = $"${Convert.ToDecimal(totalRevenue):N2}"; // Card 3: Total Revenue
                lblsales.Text = $"${Convert.ToDecimal(todaySales):N2}";         // Card 4: Today's Sales

                // 2. Fetch Latest Transaction for Recent Transactions Table
                string recentQuery = @"
            SELECT TOP 1 
                S.SaleID, 
                ISNULL(C.Name, 'Walk-in Customer') AS CustomerName, 
                S.SaleDate, 
                S.TotalAmount 
            FROM Sales S
            LEFT JOIN Customers C ON S.CustomerID = C.CustomerID
            ORDER BY S.SaleDate DESC";

                DataTable dtRecent = DatabaseHelper.ExecuteQuery(recentQuery);

                if (dtRecent != null && dtRecent.Rows.Count > 0)
                {
                    DataRow row = dtRecent.Rows[0];

                    int saleId = Convert.ToInt32(row["SaleID"]);
                    string customer = row["CustomerName"].ToString();
                    DateTime date = Convert.ToDateTime(row["SaleDate"]);
                    decimal amount = Convert.ToDecimal(row["TotalAmount"]);

                    // Bind values to UI labels
                    lblInvoiceTransaction.Text = $"#INV-{saleId:D3}";
                    lblCustomerTransaction.Text = customer;
                    lblDateTransaction.Text = date.ToString("dd MMM");
                    lblAmountTransaction.Text = $"${amount:F2}";
                }
                else
                {
                    SetDefaultRecentTransaction();
                }
            }
            catch (Exception ex)
            {
                lblTotalProduct.Text = "0";
                lblTotalCustomer.Text = "0";
                lblTotalSale.Text = "$0.00";
                lblsales.Text = "$0.00";

                SetDefaultRecentTransaction();

                Console.WriteLine("Dashboard summary error: " + ex.Message);
            }
        }

        private void SetDefaultRecentTransaction()
        {
            lblInvoiceTransaction.Text = "N/A";
            lblCustomerTransaction.Text = "N/A";
            lblDateTransaction.Text = "-";
            lblAmountTransaction.Text = "$0.00";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SwitchToDashboardView();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            User.CurrentUser = null;

            if (_loginForm != null)
            {
                _loginForm.SetLogoutMode(); // Reset login form to login mode
                _loginForm.Show(); // Unhide original login form
            }
            else
            {
                LoginForm login = new LoginForm();
                login.SetLoginMode();
                login.Show();
            }

            this.Close();
        }

        private void lblRecentTitle_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SaleHistory(), "Sale History", btnSaleHistory);
            SetActiveNavButton(btnSaleHistory);
        }

        private void lblInvoiceTransaction_Click(object sender, EventArgs e)
        {

        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SaleReportForm(), "Sales Report", btnSaleReport);
            SetActiveNavButton(btnSaleReport);

        }
    }
}
