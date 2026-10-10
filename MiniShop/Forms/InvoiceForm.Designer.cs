namespace MiniShop.Forms
{
    partial class InvoiceForm
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
            pnlHeader = new Panel();
            logo = new PictureBox();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlContent = new Panel();
            Label1 = new Label();
            lblInvoiceId = new Label();
            label2 = new Label();
            lblDate = new Label();
            label3 = new Label();
            lblCustomer = new Label();
            label4 = new Label();
            lblCashier = new Label();
            dgvInvoice = new DataGridView();
            lblSubtotal = new Label();
            lblSubtotalValue = new Label();
            lblDiscount = new Label();
            lblDiscountValue = new Label();
            lblGrandTotal = new Label();
            lblGrandtotalValue = new Label();
            lblThank = new Label();
            pnlFooter = new Panel();
            btnPrint = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(logo);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Location = new Point(25, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(434, 100);
            pnlHeader.TabIndex = 0;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.skincare_project_logo_removebg;
            logo.Location = new Point(187, 8);
            logo.Name = "logo";
            logo.Size = new Size(60, 45);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(232, 82, 133);
            lblTitle.Location = new Point(0, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(434, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SKINCARE MINI SHOP";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(0, 77);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(434, 18);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "SALE RECEIPT / INVOICE";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(Label1);
            pnlContent.Controls.Add(lblInvoiceId);
            pnlContent.Controls.Add(label2);
            pnlContent.Controls.Add(lblDate);
            pnlContent.Controls.Add(label3);
            pnlContent.Controls.Add(lblCustomer);
            pnlContent.Controls.Add(label4);
            pnlContent.Controls.Add(lblCashier);
            pnlContent.Controls.Add(dgvInvoice);
            pnlContent.Controls.Add(lblSubtotal);
            pnlContent.Controls.Add(lblSubtotalValue);
            pnlContent.Controls.Add(lblDiscount);
            pnlContent.Controls.Add(lblDiscountValue);
            pnlContent.Controls.Add(lblGrandTotal);
            pnlContent.Controls.Add(lblGrandtotalValue);
            pnlContent.Controls.Add(lblThank);
            pnlContent.Location = new Point(25, 120);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(434, 465);
            pnlContent.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(20, 10);
            Label1.Name = "Label1";
            Label1.Size = new Size(83, 20);
            Label1.TabIndex = 0;
            Label1.Text = "Invoice ID:";
            // 
            // lblInvoiceId
            // 
            lblInvoiceId.AutoSize = true;
            lblInvoiceId.Font = new Font("Segoe UI", 9F);
            lblInvoiceId.ForeColor = Color.FromArgb(64, 64, 64);
            lblInvoiceId.Location = new Point(115, 10);
            lblInvoiceId.Name = "lblInvoiceId";
            lblInvoiceId.Size = new Size(63, 20);
            lblInvoiceId.TabIndex = 1;
            lblInvoiceId.Text = "INV-009";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(20, 32);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Date:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F);
            lblDate.ForeColor = Color.FromArgb(64, 64, 64);
            lblDate.Location = new Point(115, 32);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(124, 20);
            lblDate.TabIndex = 5;
            lblDate.Text = "2026-10-06 16:16";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(20, 54);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Customer:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 9F);
            lblCustomer.ForeColor = Color.FromArgb(64, 64, 64);
            lblCustomer.Location = new Point(115, 54);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(102, 20);
            lblCustomer.TabIndex = 6;
            lblCustomer.Text = "Test Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(20, 76);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 4;
            label4.Text = "Cashier:";
            // 
            // lblCashier
            // 
            lblCashier.AutoSize = true;
            lblCashier.Font = new Font("Segoe UI", 9F);
            lblCashier.ForeColor = Color.FromArgb(64, 64, 64);
            lblCashier.Location = new Point(115, 76);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new Size(53, 20);
            lblCashier.TabIndex = 7;
            lblCashier.Text = "Admin";
            // 
            // dgvInvoice
            // 
            dgvInvoice.AllowUserToAddRows = false;
            dgvInvoice.AllowUserToDeleteRows = false;
            dgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoice.BackgroundColor = Color.White;
            dgvInvoice.BorderStyle = BorderStyle.None;
            dgvInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 228, 236);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(232, 82, 133);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(252, 228, 236);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(232, 82, 133);
            dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInvoice.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoice.EnableHeadersVisualStyles = false;
            dgvInvoice.GridColor = Color.FromArgb(248, 187, 208);
            dgvInvoice.Location = new Point(20, 110);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.ReadOnly = true;
            dgvInvoice.RowHeadersVisible = false;
            dgvInvoice.RowHeadersWidth = 51;
            dgvInvoice.RowTemplate.Height = 26;
            dgvInvoice.Size = new Size(394, 210);
            dgvInvoice.TabIndex = 8;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtotal.ForeColor = Color.FromArgb(64, 64, 64);
            lblSubtotal.Location = new Point(250, 332);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(72, 20);
            lblSubtotal.TabIndex = 9;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.Font = new Font("Segoe UI", 9F);
            lblSubtotalValue.ForeColor = Color.FromArgb(64, 64, 64);
            lblSubtotalValue.Location = new Point(330, 332);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(84, 20);
            lblSubtotalValue.TabIndex = 10;
            lblSubtotalValue.Text = "$12.00";
            lblSubtotalValue.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiscount.ForeColor = Color.FromArgb(64, 64, 64);
            lblDiscount.Location = new Point(220, 356);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(104, 20);
            lblDiscount.TabIndex = 11;
            lblDiscount.Text = "Discount (%):";
            // 
            // lblDiscountValue
            // 
            lblDiscountValue.Font = new Font("Segoe UI", 9F);
            lblDiscountValue.ForeColor = Color.FromArgb(64, 64, 64);
            lblDiscountValue.Location = new Point(330, 356);
            lblDiscountValue.Name = "lblDiscountValue";
            lblDiscountValue.Size = new Size(84, 20);
            lblDiscountValue.TabIndex = 12;
            lblDiscountValue.Text = "0%";
            lblDiscountValue.TextAlign = ContentAlignment.TopRight;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGrandTotal.ForeColor = Color.FromArgb(232, 82, 133);
            lblGrandTotal.Location = new Point(203, 383);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(121, 25);
            lblGrandTotal.TabIndex = 13;
            lblGrandTotal.Text = "Grand Total:";
            // 
            // lblGrandtotalValue
            // 
            lblGrandtotalValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGrandtotalValue.ForeColor = Color.FromArgb(232, 82, 133);
            lblGrandtotalValue.Location = new Point(325, 383);
            lblGrandtotalValue.Name = "lblGrandtotalValue";
            lblGrandtotalValue.Size = new Size(89, 25);
            lblGrandtotalValue.TabIndex = 14;
            lblGrandtotalValue.Text = "$12.00";
            lblGrandtotalValue.TextAlign = ContentAlignment.TopRight;
            // 
            // lblThank
            // 
            lblThank.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblThank.ForeColor = Color.FromArgb(232, 82, 133);
            lblThank.Location = new Point(0, 428);
            lblThank.Name = "lblThank";
            lblThank.Size = new Size(434, 25);
            lblThank.TabIndex = 15;
            lblThank.Text = "~ Thank you for shopping with us! ~";
            lblThank.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(btnPrint);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Location = new Point(25, 595);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(434, 50);
            pnlFooter.TabIndex = 2;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(232, 82, 133);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(0, 5);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(210, 38);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print Invoice";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(252, 228, 236);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(248, 187, 208);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(232, 82, 133);
            btnClose.Location = new Point(224, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(210, 38);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 242, 248);
            ClientSize = new Size(484, 661);
            Controls.Add(pnlFooter);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sales Receipt";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox logo;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel pnlContent;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblInvoiceId;
        private Label Label1;
        private DataGridView dgvInvoice;
        private Label lblCashier;
        private Label lblCustomer;
        private Label lblDate;
        private Label lblThank;
        private Label lblGrandtotalValue;
        private Label lblGrandTotal;
        private Label lblDiscountValue;
        private Label lblDiscount;
        private Label lblSubtotalValue;
        private Label lblSubtotal;
        private Panel pnlFooter;
        private Button btnClose;
        private Button btnPrint;
    }
}