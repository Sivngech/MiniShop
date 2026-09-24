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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(624, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(472, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Product Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 120);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Product ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 91);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 134);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Quantity :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(154, 81);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 6;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(154, 120);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(125, 27);
            txtProductID.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(475, 84);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(475, 131);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(351, 171);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(475, 171);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.Location = new Point(602, 171);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDelete_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(1, 275);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(807, 260);
            dgvProducts.TabIndex = 14;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 171);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 15;
            label7.Text = "Category Name :";
            // 
            // comCategory
            // 
            comCategory.FormattingEnabled = true;
            comCategory.Items.AddRange(new object[] { "Cleansers", "Toners & Essences", "Serums & Ampoules", "Moisturizers", "Sunscreens", "Face Masks", "Lip Care" });
            comCategory.Location = new Point(154, 163);
            comCategory.Name = "comCategory";
            comCategory.Size = new Size(151, 28);
            comCategory.TabIndex = 16;
            // 
            // Product_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
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
            Text = "Product_Management";
            Load += Product_Management_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
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
    }
}