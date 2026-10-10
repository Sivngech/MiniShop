namespace MiniShop.Forms
{
    partial class pos_sale
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            topPanel = new Panel();
            lblHeader = new Label();
            lblCust = new Label();
            cbCustomers = new ComboBox();
            lblVIPBadge = new Label();
            leftPanel = new Panel();
            cardProducts = new Panel();
            dgvProducts = new DataGridView();
            lblProdTitle = new Label();
            addQtyPanel = new Panel();
            btnAddToCart = new Button();
            numQty = new NumericUpDown();
            lblQty = new Label();
            rightPanel = new Panel();
            cardCart = new Panel();
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
            cardProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            addQtyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            rightPanel.SuspendLayout();
            cardCart.SuspendLayout();
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
            topPanel.Padding = new Padding(15, 10, 15, 10);
            topPanel.Size = new Size(1000, 60);
            topPanel.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(232, 93, 136);
            lblHeader.Location = new Point(15, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(233, 31);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "POS / Sales Terminal";
            // 
            // lblCust
            // 
            lblCust.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCust.AutoSize = true;
            lblCust.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCust.ForeColor = Color.FromArgb(70, 70, 70);
            lblCust.Location = new Point(540, 20);
            lblCust.Name = "lblCust";
            lblCust.Size = new Size(88, 21);
            lblCust.TabIndex = 1;
            lblCust.Text = "Customer:";
            // 
            // cbCustomers
            // 
            cbCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomers.Font = new Font("Segoe UI", 9.5F);
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(635, 16);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(190, 29);
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
            lblVIPBadge.Location = new Point(835, 17);
            lblVIPBadge.Name = "lblVIPBadge";
            lblVIPBadge.Padding = new Padding(6, 4, 6, 4);
            lblVIPBadge.Size = new Size(131, 28);
            lblVIPBadge.TabIndex = 3;
            lblVIPBadge.Text = "★ VIP +5% OFF";
            lblVIPBadge.Visible = false;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(cardProducts);
            leftPanel.Controls.Add(addQtyPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 60);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(15);
            leftPanel.Size = new Size(510, 540);
            leftPanel.TabIndex = 1;
            // 
            // cardProducts
            // 
            cardProducts.BackColor = Color.White;
            cardProducts.Controls.Add(dgvProducts);
            cardProducts.Controls.Add(lblProdTitle);
            cardProducts.Dock = DockStyle.Fill;
            cardProducts.Location = new Point(15, 15);
            cardProducts.Name = "cardProducts";
            cardProducts.Padding = new Padding(12);
            cardProducts.Size = new Size(480, 450);
            cardProducts.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeight = 29;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(12, 44);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.ScrollBars = ScrollBars.Vertical;
            dgvProducts.Size = new Size(456, 394);
            dgvProducts.TabIndex = 1;
            // 
            // lblProdTitle
            // 
            lblProdTitle.Dock = DockStyle.Top;
            lblProdTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblProdTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblProdTitle.Location = new Point(12, 12);
            lblProdTitle.Name = "lblProdTitle";
            lblProdTitle.Size = new Size(456, 32);
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
            addQtyPanel.Size = new Size(480, 60);
            addQtyPanel.TabIndex = 2;
            addQtyPanel.Paint += addQtyPanel_Paint;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddToCart.BackColor = Color.FromArgb(232, 93, 136);
            btnAddToCart.Cursor = Cursors.Hand;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(310, 10);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(170, 40);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "+ Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // numQty
            // 
            numQty.Font = new Font("Segoe UI", 10F);
            numQty.Location = new Point(52, 15);
            numQty.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(75, 30);
            numQty.TabIndex = 1;
            numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblQty.ForeColor = Color.FromArgb(70, 70, 70);
            lblQty.Location = new Point(5, 18);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(41, 21);
            lblQty.TabIndex = 0;
            lblQty.Text = "Qty:";
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(cardCart);
            rightPanel.Controls.Add(summaryPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(510, 60);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(15);
            rightPanel.Size = new Size(490, 540);
            rightPanel.TabIndex = 2;
            // 
            // cardCart
            // 
            cardCart.BackColor = Color.White;
            cardCart.Controls.Add(dgvCart);
            cardCart.Controls.Add(lblCartTitle);
            cardCart.Dock = DockStyle.Fill;
            cardCart.Location = new Point(15, 15);
            cardCart.Name = "cardCart";
            cardCart.Padding = new Padding(12);
            cardCart.Size = new Size(460, 310);
            cardCart.TabIndex = 1;
            // 
            // dgvCart
            // 
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.BorderStyle = BorderStyle.None;
            dgvCart.ColumnHeadersHeight = 29;
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.Location = new Point(12, 44);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(436, 254);
            dgvCart.TabIndex = 1;
            // 
            // lblCartTitle
            // 
            lblCartTitle.Dock = DockStyle.Top;
            lblCartTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCartTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblCartTitle.Location = new Point(12, 12);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(436, 32);
            lblCartTitle.TabIndex = 0;
            lblCartTitle.Text = "Cart Items";
            lblCartTitle.Click += lblCartTitle_Click;
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
            summaryPanel.Location = new Point(15, 325);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Padding = new Padding(15);
            summaryPanel.Size = new Size(460, 200);
            summaryPanel.TabIndex = 2;
            // 
            // btnCompleteSale
            // 
            btnCompleteSale.BackColor = Color.FromArgb(232, 93, 136);
            btnCompleteSale.Cursor = Cursors.Hand;
            btnCompleteSale.Dock = DockStyle.Bottom;
            btnCompleteSale.FlatAppearance.BorderSize = 0;
            btnCompleteSale.FlatStyle = FlatStyle.Flat;
            btnCompleteSale.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCompleteSale.ForeColor = Color.White;
            btnCompleteSale.Location = new Point(15, 140);
            btnCompleteSale.Name = "btnCompleteSale";
            btnCompleteSale.Size = new Size(430, 45);
            btnCompleteSale.TabIndex = 6;
            btnCompleteSale.Text = "CHECKOUT / COMPLETE SALE";
            btnCompleteSale.UseVisualStyleBackColor = false;
            btnCompleteSale.Click += btnCompleteSale_Click;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblGrandTotal.ForeColor = Color.FromArgb(232, 93, 136);
            lblGrandTotal.Location = new Point(335, 93);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(78, 35);
            lblGrandTotal.TabIndex = 5;
            lblGrandTotal.Text = "$0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(30, 30, 30);
            label3.Location = new Point(20, 98);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 4;
            label3.Text = "Grand Total:";
            // 
            // txtDiscount
            // 
            txtDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDiscount.Font = new Font("Segoe UI", 9.5F);
            txtDiscount.Location = new Point(348, 54);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(70, 29);
            txtDiscount.TabIndex = 3;
            txtDiscount.Text = "0";
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F);
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(20, 58);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 2;
            label2.Text = "Discount (%):";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblSubtotal.ForeColor = Color.FromArgb(40, 40, 40);
            lblSubtotal.Location = new Point(360, 18);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(57, 25);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "$0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
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
            cardProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            addQtyPanel.ResumeLayout(false);
            addQtyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            rightPanel.ResumeLayout(false);
            cardCart.ResumeLayout(false);
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
        private Panel cardProducts;
        private Label lblProdTitle;
        private DataGridView dgvProducts;
        private Panel addQtyPanel;
        private NumericUpDown numQty;
        private Label lblQty;
        private Button btnAddToCart;
        private Panel rightPanel;
        private Panel cardCart;
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