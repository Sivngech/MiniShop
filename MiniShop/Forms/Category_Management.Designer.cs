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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnHeader = new Panel();
            lblTitle = new Label();
            pnSearchArea = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            pnInputCard = new Panel();
            tlpInputs = new TableLayoutPanel();
            lblCategoryID = new Label();
            txtCategoryID = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            lblStatus = new Label();
            flpStatus = new FlowLayoutPanel();
            rbActive = new RadioButton();
            rbInactive = new RadioButton();
            flpActions = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            pnGridContainer = new Panel();
            dgvCategories = new DataGridView();
            pnHeader.SuspendLayout();
            pnSearchArea.SuspendLayout();
            pnInputCard.SuspendLayout();
            tlpInputs.SuspendLayout();
            flpStatus.SuspendLayout();
            flpActions.SuspendLayout();
            pnGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(lblTitle);
            pnHeader.Controls.Add(pnSearchArea);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(20, 20);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(942, 60);
            pnHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(232, 82, 133);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(314, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Category Management";
            // 
            // pnSearchArea
            // 
            pnSearchArea.Controls.Add(lblSearch);
            pnSearchArea.Controls.Add(txtSearch);
            pnSearchArea.Controls.Add(btnSearch);
            pnSearchArea.Dock = DockStyle.Right;
            pnSearchArea.Location = new Point(462, 0);
            pnSearchArea.Name = "pnSearchArea";
            pnSearchArea.Size = new Size(480, 60);
            pnSearchArea.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(232, 82, 133);
            lblSearch.Location = new Point(0, 8);
            lblSearch.Margin = new Padding(0, 8, 8, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(67, 3);
            txtSearch.Margin = new Padding(0, 3, 8, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name...";
            txtSearch.Size = new Size(240, 30);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(232, 82, 133);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(315, 2);
            btnSearch.Margin = new Padding(0, 2, 0, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
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
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tlpInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInputs.Controls.Add(lblCategoryID, 0, 0);
            tlpInputs.Controls.Add(txtCategoryID, 1, 0);
            tlpInputs.Controls.Add(lblDescription, 2, 0);
            tlpInputs.Controls.Add(txtDescription, 3, 0);
            tlpInputs.Controls.Add(lblCategoryName, 0, 1);
            tlpInputs.Controls.Add(txtCategoryName, 1, 1);
            tlpInputs.Controls.Add(lblStatus, 2, 1);
            tlpInputs.Controls.Add(flpStatus, 3, 1);
            tlpInputs.Dock = DockStyle.Top;
            tlpInputs.Location = new Point(15, 15);
            tlpInputs.Name = "tlpInputs";
            tlpInputs.RowCount = 2;
            tlpInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInputs.Size = new Size(912, 90);
            tlpInputs.TabIndex = 0;
            // 
            // lblCategoryID
            // 
            lblCategoryID.Anchor = AnchorStyles.Left;
            lblCategoryID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoryID.ForeColor = Color.FromArgb(232, 82, 133);
            lblCategoryID.Location = new Point(3, 11);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(100, 23);
            lblCategoryID.TabIndex = 0;
            lblCategoryID.Text = "Category ID:";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryID.BackColor = Color.FromArgb(252, 228, 236);
            txtCategoryID.Location = new Point(133, 9);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(330, 27);
            txtCategoryID.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Left;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(232, 82, 133);
            lblDescription.Location = new Point(469, 11);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(579, 9);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(330, 27);
            txtDescription.TabIndex = 3;
            // 
            // lblCategoryName
            // 
            lblCategoryName.Anchor = AnchorStyles.Left;
            lblCategoryName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoryName.ForeColor = Color.FromArgb(232, 82, 133);
            lblCategoryName.Location = new Point(3, 56);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(100, 23);
            lblCategoryName.TabIndex = 4;
            lblCategoryName.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryName.Location = new Point(133, 54);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(330, 27);
            txtCategoryName.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(232, 82, 133);
            lblStatus.Location = new Point(469, 56);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            // 
            // flpStatus
            // 
            flpStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flpStatus.Controls.Add(rbActive);
            flpStatus.Controls.Add(rbInactive);
            flpStatus.Location = new Point(576, 50);
            flpStatus.Margin = new Padding(0);
            flpStatus.Name = "flpStatus";
            flpStatus.Size = new Size(336, 35);
            flpStatus.TabIndex = 7;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbActive.ForeColor = Color.FromArgb(64, 64, 64);
            rbActive.Location = new Point(0, 8);
            rbActive.Margin = new Padding(0, 8, 15, 0);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(74, 24);
            rbActive.TabIndex = 0;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbInactive.ForeColor = Color.FromArgb(64, 64, 64);
            rbInactive.Location = new Point(89, 8);
            rbInactive.Margin = new Padding(0, 8, 0, 0);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(85, 24);
            rbInactive.TabIndex = 1;
            rbInactive.Text = "Inactive";
            rbInactive.UseVisualStyleBackColor = true;
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
            // 
            // pnGridContainer
            // 
            pnGridContainer.Controls.Add(dgvCategories);
            pnGridContainer.Dock = DockStyle.Fill;
            pnGridContainer.Location = new Point(20, 265);
            pnGridContainer.Name = "pnGridContainer";
            pnGridContainer.Padding = new Padding(0, 15, 0, 0);
            pnGridContainer.Size = new Size(942, 368);
            pnGridContainer.TabIndex = 0;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 242, 248);
            dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.BackgroundColor = Color.White;
            dgvCategories.BorderStyle = BorderStyle.None;
            dgvCategories.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(252, 228, 236);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(232, 82, 133);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(252, 228, 236);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(232, 82, 133);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.ColumnHeadersHeight = 40;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(248, 187, 208);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.GridColor = Color.FromArgb(248, 187, 208);
            dgvCategories.Location = new Point(0, 15);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 35;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(942, 353);
            dgvCategories.TabIndex = 0;
            // 
            // Category_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 242, 248);
            ClientSize = new Size(982, 653);
            Controls.Add(pnGridContainer);
            Controls.Add(pnInputCard);
            Controls.Add(pnHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Category_Management";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnSearchArea.ResumeLayout(false);
            pnSearchArea.PerformLayout();
            pnInputCard.ResumeLayout(false);
            tlpInputs.ResumeLayout(false);
            tlpInputs.PerformLayout();
            flpStatus.ResumeLayout(false);
            flpStatus.PerformLayout();
            flpActions.ResumeLayout(false);
            pnGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Label lblTitle;
        private FlowLayoutPanel pnSearchArea;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;

        private Panel pnInputCard;
        private TableLayoutPanel tlpInputs;
        private Label lblCategoryID;
        private TextBox txtCategoryID;
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblStatus;
        private FlowLayoutPanel flpStatus;
        private RadioButton rbActive;
        private RadioButton rbInactive;

        private FlowLayoutPanel flpActions;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private Panel pnGridContainer;
        private DataGridView dgvCategories;
    }
}