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
        }
        private void OpenChildForm(Form childForm, string title, Button activeNavButton)
        {
            // Close current active child form if exists
            if (activeForm != null)
            {
                activeForm.Close();
            }

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

            pnlSummary.Visible = true;
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
            //OpenChildForm(new CustomerForm(), "Customer Management", btnCustomer);
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
            OpenChildForm(new pos_sale(), "POS/Sale Management", btnSale);
            SetActiveNavButton(btnSale);
        }
        private void LoadDashboardSummary()
        {
            try
            {
                // Execute SQL queries to fetch real counts
                object countProducts = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Products") ?? 0;
                object countCustomers = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM Customers") ?? 0;
                object totalSales = DatabaseHelper.ExecuteScalar("SELECT ISNULL(SUM(TotalAmount), 0) FROM Sales") ?? 0;

                // Assign counts to your form labels (Ensure label names match your Designer properties)
                lblTotalProduct.Text = countProducts.ToString();
                lblTotalCustomer.Text = countCustomers.ToString();
                lblTotalSale.Text = $"${Convert.ToDecimal(totalSales):N2}";
            }
            catch (Exception ex)
            {
                // Safe fallback in case database tables haven't been created by teammates yet
                lblTotalProduct.Text = "0";
                lblTotalCustomer.Text = "0";
                lblTotalSale.Text = "$0.00";
                Console.WriteLine("Dashboard summary error: " + ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //lblTitle.Text = "Dashboard Overview";
            //LoadDashboardSummary();
            OpenChildForm(new MainDashboardForm(), "Dashboard Overview", btnDashboard);
            SetActiveNavButton(btnDashboard);
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
            //OpenChildForm(new SaleHistoryForm(), "Sale History", btnSaleHistory);

            SetActiveNavButton(btnSaleHistory);
            lblTitle.Text = "Sale History";
        }

        private void lblInvoiceTransaction_Click(object sender, EventArgs e)
        {

        }
    }
}
