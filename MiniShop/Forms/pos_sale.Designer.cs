namespace MiniShop.Forms
{
    partial class pos_sale
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
            topPanel = new Panel();
            lblHeader = new Label();
            lblCust = new Label();
            cbCustomers = new ComboBox();
            lblVIPBadge = new Label();
            leftPanel = new Panel();
            dgvProducts = new DataGridView();
            lblProdTitle = new Label();
            addQtyPanel = new Panel();
            btnAddToCart = new Button();
            numQty = new NumericUpDown();
            lblQty = new Label();
            rightPanel = new Panel();
            dgvCart = new DataGridView();
            lblCartTitle = new Label();
            summaryPanel = new Panel();
            btnCompleteSale = new Button();
            lblGrandTotal = new Label();
            label3 = new Label();
            txtDiscount = new TextBox();
            label2 = new Label();
            lblSubtotal = new Label();
            label1 = new Label();
            topPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            addQtyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(lblHeader);
            topPanel.Controls.Add(lblCust);
            topPanel.Controls.Add(cbCustomers);
            topPanel.Controls.Add(lblVIPBadge);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1000, 60);
            topPanel.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(232, 93, 136);
            lblHeader.Location = new Point(15, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(248, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "POS / Sales Terminal";
            // 
            // lblCust
            // 
            lblCust.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCust.AutoSize = true;
            lblCust.Location = new Point(550, 20);
            lblCust.Name = "lblCust";
            lblCust.Size = new Size(75, 20);
            lblCust.TabIndex = 1;
            lblCust.Text = "Customer:";
            // 
            // cbCustomers
            // 
            cbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(635, 16);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(190, 28);
            cbCustomers.TabIndex = 2;
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            // 
            // lblVIPBadge
            // 
            lblVIPBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVIPBadge.AutoSize = true;
            lblVIPBadge.BackColor = Color.FromArgb(232, 93, 136);
            lblVIPBadge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVIPBadge.ForeColor = Color.White;
            lblVIPBadge.Location = new Point(835, 18);
            lblVIPBadge.Name = "lblVIPBadge";
            lblVIPBadge.Padding = new Padding(5, 3, 5, 3);
            lblVIPBadge.Size = new Size(129, 26);
            lblVIPBadge.TabIndex = 3;
            lblVIPBadge.Text = "★ VIP +5% OFF";
            lblVIPBadge.Visible = false;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(dgvProducts);
            leftPanel.Controls.Add(lblProdTitle);
            leftPanel.Controls.Add(addQtyPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 60);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(15);
            leftPanel.Size = new Size(520, 540);
            leftPanel.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(15, 45);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(490, 420);
            dgvProducts.TabIndex = 1;
            // 
            // lblProdTitle
            // 
            lblProdTitle.Dock = DockStyle.Top;
            lblProdTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblProdTitle.Location = new Point(15, 15);
            lblProdTitle.Name = "lblProdTitle";
            lblProdTitle.Size = new Size(490, 30);
            lblProdTitle.TabIndex = 0;
            lblProdTitle.Text = "Available Products";
            // 
            // addQtyPanel
            // 
            addQtyPanel.Controls.Add(btnAddToCart);
            addQtyPanel.Controls.Add(numQty);
            addQtyPanel.Controls.Add(lblQty);
            addQtyPanel.Dock = DockStyle.Bottom;
            addQtyPanel.Location = new Point(15, 465);
            addQtyPanel.Name = "addQtyPanel";
            addQtyPanel.Size = new Size(490, 60);
            addQtyPanel.TabIndex = 2;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddToCart.BackColor = Color.FromArgb(232, 93, 136);
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(330, 12);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(160, 36);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "+ Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // numQty
            // 
            numQty.Location = new Point(45, 17);
            numQty.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(70, 27);
            numQty.TabIndex = 1;
            numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(5, 20);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(35, 20);
            lblQty.TabIndex = 0;
            lblQty.Text = "Qty:";
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(dgvCart);
            rightPanel.Controls.Add(lblCartTitle);
            rightPanel.Controls.Add(summaryPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(520, 60);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(15);
            rightPanel.Size = new Size(480, 540);
            rightPanel.TabIndex = 2;
            // 
            // dgvCart
            // 
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.Location = new Point(15, 45);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(450, 290);
            dgvCart.TabIndex = 1;
            // 
            // lblCartTitle
            // 
            lblCartTitle.Dock = DockStyle.Top;
            lblCartTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCartTitle.Location = new Point(15, 15);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(450, 30);
            lblCartTitle.TabIndex = 0;
            lblCartTitle.Text = "Cart Items";
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.White;
            summaryPanel.Controls.Add(btnCompleteSale);
            summaryPanel.Controls.Add(lblGrandTotal);
            summaryPanel.Controls.Add(label3);
            summaryPanel.Controls.Add(txtDiscount);
            summaryPanel.Controls.Add(label2);
            summaryPanel.Controls.Add(lblSubtotal);
            summaryPanel.Controls.Add(label1);
            summaryPanel.Dock = DockStyle.Bottom;
            summaryPanel.Location = new Point(15, 335);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(450, 190);
            summaryPanel.TabIndex = 2;
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCompleteSale.BackColor = Color.FromArgb(232, 93, 136);
            btnCompleteSale.FlatAppearance.BorderSize = 0;
            btnCompleteSale.FlatStyle = FlatStyle.Flat;
            btnCompleteSale.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCompleteSale.ForeColor = Color.White;
            btnCompleteSale.Location = new Point(20, 130);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(410, 45);
            btnCompleteSale.TabIndex = 6;
            btnCompleteSale.Text = "CHECKOUT / COMPLETE SALE";
            btnCompleteSale.UseVisualStyleBackColor = false;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblGrandTotal.ForeColor = Color.FromArgb(232, 93, 136);
            lblGrandTotal.Location = new Point(160, 85);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(77, 32);
            lblGrandTotal.TabIndex = 5;
            lblGrandTotal.Text = "$0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(20, 88);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 4;
            label3.Text = "Grand Total:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(160, 47);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(70, 27);
            txtDiscount.TabIndex = 3;
            txtDiscount.Text = "0";
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Discount (%):";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotal.Location = new Point(160, 15);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(55, 23);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "$0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // pos_sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 240, 243);
            ClientSize = new Size(1000, 600);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Controls.Add(topPanel);
            Name = "pos_sale";
            Text = "POS / Sale";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            addQtyPanel.ResumeLayout(false);
            addQtyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Label lblHeader;
        private Label lblCust;
        private ComboBox cbCustomers;
        private Label lblVIPBadge;
        private Panel leftPanel;
        private Label lblProdTitle;
        private DataGridView dgvProducts;
        private Panel addQtyPanel;
        private NumericUpDown numQty;
        private Label lblQty;
        private Button btnAddToCart;
        private Panel rightPanel;
        private DataGridView dgvCart;
        private Label lblCartTitle;
        private Panel summaryPanel;
        private Label label1;
        private TextBox txtDiscount;
        private Label label2;
        private Label lblSubtotal;
        private Button btnCompleteSale;
        private Label lblGrandTotal;
        private Label label3;
    }
}