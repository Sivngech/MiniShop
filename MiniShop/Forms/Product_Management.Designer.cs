namespace MiniShop.Forms
{
    partial class Product_Management
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            button3 = new Button();
            dgvProducts = new DataGridView();
            label7 = new Label();
            comCategory = new ComboBox();
            pbImage = new PictureBox();
            lblImage = new Label();
            btnBrowseImage = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(226, 75, 122);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 60);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.FromArgb(226, 75, 122);
            btnSearch.Location = new Point(911, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(674, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(247, 31);
            label1.TabIndex = 1;
            label1.Text = "Product Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(90, 60, 75);
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(90, 60, 75);
            label3.Location = new Point(34, 120);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Product ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(90, 60, 75);
            label5.Location = new Point(403, 88);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(90, 60, 75);
            label6.Location = new Point(376, 127);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 5;
            label6.Text = "Quantity :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(154, 78);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(180, 27);
            txtProductName.TabIndex = 6;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(154, 117);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(180, 27);
            txtProductID.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(475, 81);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(475, 120);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(180, 27);
            txtQuantity.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(226, 75, 122);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(538, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 32);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(226, 75, 122);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(655, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 32);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.FromArgb(226, 75, 122);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(226, 75, 122);
            button3.Location = new Point(772, 222);
            button3.Name = "button3";
            button3.Size = new Size(94, 32);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnDelete_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(226, 75, 122);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(226, 75, 122);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 215, 225);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(22, 260);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(956, 300);
            dgvProducts.TabIndex = 14;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(90, 60, 75);
            label7.Location = new Point(327, 179);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 15;
            label7.Text = "Category Name :";
            // 
            // comCategory
            // 
            comCategory.FormattingEnabled = true;
            comCategory.Items.AddRange(new object[] { "Cleansers", "Toners & Essences", "Serums & Ampoules", "Moisturizers", "Sunscreens", "Face Masks", "Lip Care" });
            comCategory.Location = new Point(475, 171);
            comCategory.Name = "comCategory";
            comCategory.Size = new Size(180, 28);
            comCategory.TabIndex = 16;
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(154, 168);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(145, 86);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 17;
            pbImage.TabStop = false;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblImage.ForeColor = Color.FromArgb(90, 60, 75);
            lblImage.Location = new Point(69, 168);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(57, 20);
            lblImage.TabIndex = 18;
            lblImage.Text = "Image:";
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(69, 202);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(70, 35);
            btnBrowseImage.TabIndex = 19;
            btnBrowseImage.Text = "Browse";
            btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(226, 75, 122);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(226, 75, 122);
            btnClear.Location = new Point(884, 222);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 32);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // Product_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 240, 243);
            ClientSize = new Size(1028, 592);
            Controls.Add(btnClear);
            Controls.Add(btnBrowseImage);
            Controls.Add(lblImage);
            Controls.Add(pbImage);
            Controls.Add(comCategory);
            Controls.Add(label7);
            Controls.Add(dgvProducts);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtProductID);
            Controls.Add(txtProductName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Product_Management";
            Text = "Product Management";
            Load += Product_Management_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button button3;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvProducts;
        private Label label7;
        private ComboBox comCategory;
        private PictureBox pbImage;
        private Label lblImage;
        private Button btnBrowseImage;
        private Button btnClear;
    }
}