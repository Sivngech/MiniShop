using MiniShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class LoginForm : Form
    {
        // Tracks state so clicking Logout doesn't trigger the SQL login
        private bool isLogoutMode = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        // Called when opening form from Dashboard Logout button
        public void SetLogoutMode()
        {
            isLogoutMode = true;

            // 1. Change Window Bar Title
            this.Text = "Logout Form";

            // 2. Change Big Header Text (Change 'label1' if your designer label is named differently)
            if (this.Controls.Find("label1", true).Length > 0)
            {
                this.Controls.Find("label1", true)[0].Text = "Logout Form";
            }

            // 3. Change Button Text
            btnLogin.Text = "Logout";

            // Disable input fields while in logout mode
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
        }

        public void SetLoginMode()
        {
            isLogoutMode = false;

            this.Text = "Login Form";

            if (this.Controls.Find("label1", true).Length > 0)
            {
                this.Controls.Find("label1", true)[0].Text = "Login Form";
            }

            btnLogin.Text = "Login";

            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // IF LOGOUT MODE: Just reset to Login state and exit
            if (isLogoutMode || btnLogin.Text == "Logout")
            {
                SetLoginMode();
                MessageBox.Show("You have successfully logged out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // STOP EXECUTION (Prevents dashboard from re-opening)
            }

            // IF LOGIN MODE: Process SQL Login
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT UserID, FullName, Role FROM Users WHERE Username = @Username AND Password = @Password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };

            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    string fullName = dt.Rows[0]["FullName"].ToString();
                    MessageBox.Show($"Welcome back, {fullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Pass this form to Dashboard
                    MainDashboardForm dashboard = new MainDashboardForm(this);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}