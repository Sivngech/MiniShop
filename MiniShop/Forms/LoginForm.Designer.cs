namespace MiniShop.Forms
{
    partial class LoginForm
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
            lblTitle = new Label();
            lblDescription = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            logo = new PictureBox();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(180, 50, 90);
            lblTitle.Location = new Point(100, 72);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 35);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "SKINCARE MINI SHOP";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 9.5F);
            lblDescription.ForeColor = Color.FromArgb(120, 100, 110);
            lblDescription.Location = new Point(100, 107);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(400, 22);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Healthy Skin  •  Happy You";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(100, 110, 120);
            label2.Location = new Point(150, 155);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(100, 110, 120);
            label3.Location = new Point(150, 225);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10.5F);
            txtUsername.ForeColor = Color.FromArgb(50, 50, 50);
            txtUsername.Location = new Point(150, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 31);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.ForeColor = Color.FromArgb(50, 50, 50);
            txtPassword.Location = new Point(150, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(300, 31);
            txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(228, 88, 136);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 70, 118);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(310, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 42);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(228, 88, 136);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 240, 245);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(228, 88, 136);
            btnCancel.Location = new Point(150, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 42);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button2_Click;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.skincare_project_logo_removebg;
            logo.Location = new Point(275, 25);
            logo.Name = "logo";
            logo.Size = new Size(50, 45);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9.5F);
            lblMessage.ForeColor = Color.FromArgb(120, 100, 110);
            lblMessage.Location = new Point(100, 370);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(400, 22);
            lblMessage.TabIndex = 9;
            lblMessage.Text = "Please login to continue";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Click += lbl_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 240);
            ClientSize = new Size(600, 430);
            Controls.Add(lblMessage);
            Controls.Add(logo);
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skincare Shop - Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
        private PictureBox logo;
        private Label lblMessage;
    }
}