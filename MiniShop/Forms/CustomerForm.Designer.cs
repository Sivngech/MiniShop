namespace MiniShop.Forms
{
    partial class CustomerForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnHeader = new Panel();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblTitle = new Label();
            pnSearchArea = new FlowLayoutPanel();
            pnInputCard = new Panel();
            tlpInputs = new TableLayoutPanel();
            lblType = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            cboCustomerType = new ComboBox();
            flpActions = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            pnGridContainer = new Panel();
            dgvCustomers = new DataGridView();
            colCustomerID = new DataGridViewTextBoxColumn();
            colCustomerType = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            pnHeader.SuspendLayout();
            pnInputCard.SuspendLayout();
            tlpInputs.SuspendLayout();
            flpActions.SuspendLayout();
            pnGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(btnRefresh);
            pnHeader.Controls.Add(btnSearch);
            pnHeader.Controls.Add(txtSearch);
            pnHeader.Controls.Add(lblTitle);
            pnHeader.Controls.Add(pnSearchArea);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(20, 20);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(942, 60);
            pnHeader.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(252, 228, 236);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(248, 187, 208);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(232, 82, 133);
            btnRefresh.Location = new Point(666, 13);
            btnRefresh.Margin = new Padding(0, 2, 0, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(85, 32);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(232, 82, 133);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(775, 13);
            btnSearch.Margin = new Padding(0, 2, 8, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(384, 13);
            txtSearch.Margin = new Padding(0, 3, 8, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name or phone...";
            txtSearch.Size = new Size(252, 30);
            txtSearch.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(232, 82, 133);
            lblTitle.Location = new Point(0, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(319, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer Management";
            // 
            // pnSearchArea
            // 
            pnSearchArea.AutoSize = true;
            pnSearchArea.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnSearchArea.Dock = DockStyle.Right;
            pnSearchArea.Location = new Point(942, 0);
            pnSearchArea.Name = "pnSearchArea";
            pnSearchArea.Size = new Size(0, 60);
            pnSearchArea.TabIndex = 1;
            // 
            // pnInputCard
            // 
            pnInputCard.BackColor = Color.White;
            pnInputCard.Controls.Add(tlpInputs);
            pnInputCard.Controls.Add(flpActions);
            pnInputCard.Dock = DockStyle.Top;
            pnInputCard.Location = new Point(20, 80);
            pnInputCard.Name = "pnInputCard";
            pnInputCard.Padding = new Padding(15, 15, 15, 10);
            pnInputCard.Size = new Size(942, 185);
            pnInputCard.TabIndex = 1;
            // 
            // tlpInputs
            // 
            tlpInputs.ColumnCount = 4;
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInputs.Controls.Add(lblType, 0, 0);
            tlpInputs.Controls.Add(lblPhone, 2, 0);
            tlpInputs.Controls.Add(txtPhone, 3, 0);
            tlpInputs.Controls.Add(lblName, 0, 1);
            tlpInputs.Controls.Add(txtName, 1, 1);
            tlpInputs.Controls.Add(lblAddress, 2, 1);
            tlpInputs.Controls.Add(txtAddress, 3, 1);
            tlpInputs.Controls.Add(cboCustomerType, 1, 0);
            tlpInputs.Dock = DockStyle.Top;
            tlpInputs.Location = new Point(15, 15);
            tlpInputs.Name = "tlpInputs";
            tlpInputs.RowCount = 2;
            tlpInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInputs.Size = new Size(912, 90);
            tlpInputs.TabIndex = 0;
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.Left;
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblType.ForeColor = Color.FromArgb(232, 82, 133);
            lblType.Location = new Point(3, 11);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 23);
            lblType.TabIndex = 0;
            lblType.Text = "Type: ";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Left;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(232, 82, 133);
            lblPhone.Location = new Point(459, 11);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(579, 9);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(330, 27);
            txtPhone.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(232, 82, 133);
            lblName.Location = new Point(3, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 4;
            lblName.Text = "Full Name:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(123, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 27);
            txtName.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.Left;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(232, 82, 133);
            lblAddress.Location = new Point(459, 56);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(579, 54);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(330, 27);
            txtAddress.TabIndex = 7;
            // 
            // cboCustomerType
            // 
            cboCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomerType.FormattingEnabled = true;
            cboCustomerType.Location = new Point(123, 3);
            cboCustomerType.Name = "cboCustomerType";
            cboCustomerType.Size = new Size(330, 27);
            cboCustomerType.TabIndex = 8;
            // 
            // flpActions
            // 
            flpActions.Controls.Add(btnAdd);
            flpActions.Controls.Add(btnUpdate);
            flpActions.Controls.Add(btnDelete);
            flpActions.Controls.Add(btnClear);
            flpActions.Dock = DockStyle.Bottom;
            flpActions.Location = new Point(15, 130);
            flpActions.Name = "flpActions";
            flpActions.Padding = new Padding(0, 10, 0, 0);
            flpActions.Size = new Size(912, 45);
            flpActions.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(232, 82, 133);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 10);
            btnAdd.Margin = new Padding(0, 0, 10, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(216, 27, 96);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(105, 10);
            btnUpdate.Margin = new Padding(0, 0, 10, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 114, 182);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(210, 10);
            btnDelete.Margin = new Padding(0, 0, 10, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(252, 228, 236);
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(248, 187, 208);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(232, 82, 133);
            btnClear.Location = new Point(315, 10);
            btnClear.Margin = new Padding(0, 0, 10, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pnGridContainer
            // 
            pnGridContainer.Controls.Add(dgvCustomers);
            pnGridContainer.Dock = DockStyle.Fill;
            pnGridContainer.Location = new Point(20, 265);
            pnGridContainer.Name = "pnGridContainer";
            pnGridContainer.Padding = new Padding(0, 15, 0, 0);
            pnGridContainer.Size = new Size(942, 368);
            pnGridContainer.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 242, 248);
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(252, 228, 236);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(232, 82, 133);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(252, 228, 236);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(232, 82, 133);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.ColumnHeadersHeight = 40;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colCustomerID, colCustomerType, colCustomerName, colPhone, colAddress });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(248, 187, 208);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.GridColor = Color.FromArgb(248, 187, 208);
            dgvCustomers.Location = new Point(0, 15);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 35;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(942, 353);
            dgvCustomers.TabIndex = 0;
            // 
            // colCustomerID
            // 
            colCustomerID.DataPropertyName = "CustomerID";
            colCustomerID.FillWeight = 40F;
            colCustomerID.HeaderText = "ID";
            colCustomerID.MinimumWidth = 6;
            colCustomerID.Name = "colCustomerID";
            colCustomerID.ReadOnly = true;
            // 
            // colCustomerType
            // 
            cboCustomerType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            colCustomerType.DataPropertyName = "CustomerType";
            colCustomerType.FillWeight = 70F;
            colCustomerType.HeaderText = "Type";
            colCustomerType.MinimumWidth = 6;
            colCustomerType.Name = "colCustomerType";
            colCustomerType.ReadOnly = true;
            // 
            // colCustomerName
            // 
            colCustomerName.DataPropertyName = "Name";
            colCustomerName.FillWeight = 110F;
            colCustomerName.HeaderText = "Customer Name";
            colCustomerName.MinimumWidth = 6;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.FillWeight = 90F;
            colPhone.HeaderText = "Phone Number";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.FillWeight = 160F;
            colAddress.HeaderText = "Address";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 242, 248);
            ClientSize = new Size(982, 653);
            Controls.Add(pnGridContainer);
            Controls.Add(pnInputCard);
            Controls.Add(pnHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CustomerForm";
            Padding = new Padding(20);
            Text = "Customer Management";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnInputCard.ResumeLayout(false);
            tlpInputs.ResumeLayout(false);
            tlpInputs.PerformLayout();
            flpActions.ResumeLayout(false);
            pnGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Label lblTitle;
        private FlowLayoutPanel pnSearchArea;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;

        private Panel pnInputCard;
        private TableLayoutPanel tlpInputs;
        private Label lblType;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;

        private FlowLayoutPanel flpActions;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private Panel pnGridContainer;
        private DataGridView dgvCustomers;
        private ComboBox cboCustomerType;
        private DataGridViewTextBoxColumn colCustomerID;
        private DataGridViewTextBoxColumn colCustomerType;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAddress;
    }
}