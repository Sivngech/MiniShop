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
            txtProductName = new TextBox();
            label3 = new Label();
            txtProductID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            txtQuantity = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvProducts = new DataGridView();
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
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 48);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(671, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(432, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(225, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Product Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(130, 57);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 109);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(130, 106);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(125, 27);
            txtProductID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 159);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 64);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(423, 64);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 109);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 9;
            label6.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(423, 109);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(313, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(433, 173);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(557, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.BackgroundColor = SystemColors.ControlLightLight;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(1, 219);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(799, 188);
            dgvProducts.TabIndex = 14;
            // 
            // comCategory
            // 
            comCategory.FormattingEnabled = true;
            comCategory.Items.AddRange(new object[] { "Serum", "Suncreen", "Moisturizing cream", "Hair mask ", "Hair shampoo", "Hair conditioner ", "Sheet mask", "Steam cell", "lipstick", "cleansing oil ", "toner pad ", "toner " });
            comCategory.Location = new Point(130, 166);
            comCategory.Name = "comCategory";
            comCategory.Size = new Size(151, 28);
            comCategory.TabIndex = 15;
            // 
            // Product_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comCategory);
            Controls.Add(dgvProducts);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtQuantity);
            Controls.Add(label6);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtProductID);
            Controls.Add(label3);
            Controls.Add(txtProductName);
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
        private TextBox txtProductName;
        private Label label3;
        private TextBox txtProductID;
        private Label label4;
        private Label label5;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvProducts;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox comCategory;
    }
}