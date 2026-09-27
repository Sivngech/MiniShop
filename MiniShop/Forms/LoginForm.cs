using MiniShop.Models;
using MiniShop.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class LoginForm : Form
    {
        // Tracks state so clicking Logout doesn't trigger SQL login
        private bool isLogoutMode = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        public void SetLogoutMode()
        {
            isLogoutMode = true;
            User.CurrentUser = null; // Clear user session on logout

            this.Text = "Logout Form";

            if (this.Controls.Find("label1", true).Length > 0)
            {
                this.Controls.Find("label1", true)[0].Text = "Logout Form";
            }

            btnLogin.Text = "Logout";

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
            if (isLogoutMode || btnLogin.Text == "Logout")
            {
                SetLoginMode();
                MessageBox.Show("You have successfully logged out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
                    DataRow row = dt.Rows[0];

                    // Set global session
                    User.CurrentUser = new User
                    {
                        UserID = Convert.ToInt32(row["UserID"]),
                        Username = username,
                        FullName = row["FullName"].ToString() ?? string.Empty,
                        Role = row["Role"].ToString() ?? string.Empty
                    };

                    MessageBox.Show($"Welcome back, {User.CurrentUser.FullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void LoginForm_Load(object sender, EventArgs e) { }

        private void lbl_Click(object sender, EventArgs e) { }
    }
}