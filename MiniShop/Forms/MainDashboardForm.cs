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
        
        public MainDashboardForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }
        public MainDashboardForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, string title)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(childForm);
            panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = title;
        }
        private void BtnProducts_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            //OpenChildForm(new ProductManagementForm(), "Product Management");
            lblTitle.Text = "Product Management";
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            // OpenChildForm(new CategoryForm(), "Category Management");
            lblTitle.Text = "Categories Management";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            // OpenChildForm(new CustomerForm(), "Customer Management");
            lblTitle.Text = "Customer Management";
        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
        }



        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new SaleForm(), "POS/Sale Management");
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            // OpenChildForm(new CustomerForm(), "Customer Management");
            lblTitle.Text = "Sale/POS";
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
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            lblTitle.Text = "Dashboard Overview";
            LoadDashboardSummary();
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
    }
}
