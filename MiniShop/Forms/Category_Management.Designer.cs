namespace MiniShop.Forms
{
    partial class Category_Management
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbActive = new RadioButton();
            rbInactive = new RadioButton();
            label6 = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvCategories = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(50, 50, 50);
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 1;
            label1.Text = "Category Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 79);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 2;
            label2.Text = "Category ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 121);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 3;
            label3.Text = "Category Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 163);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 4;
            label4.Text = "Description :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 79);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Search :";
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.Location = new Point(500, 119);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(71, 24);
            rbActive.TabIndex = 6;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.Location = new Point(590, 119);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(81, 24);
            rbInactive.TabIndex = 7;
            rbInactive.Text = "Inactive";
            rbInactive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 121);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 8;
            label6.Text = "Status :";
            // 
            // txtCategoryID
            // 
            txtCategoryID.BackColor = SystemColors.ControlLight;
            txtCategoryID.Location = new Point(148, 76);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(180, 27);
            txtCategoryID.TabIndex = 9;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(148, 118);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(180, 27);
            txtCategoryName.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(148, 160);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(180, 27);
            txtDescription.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(480, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightPink;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(670, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(0, 250);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(802, 290);
            dgvCategories.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightPink;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(350, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightPink;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(455, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightPink;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(560, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightPink;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(665, 200);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // Category_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 543);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvCategories);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label6);
            Controls.Add(rbInactive);
            Controls.Add(rbActive);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Category_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rbActive;
        private RadioButton rbInactive;
        private Label label6;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvCategories;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}