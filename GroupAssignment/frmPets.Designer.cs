
namespace WinformPetStore
{
    partial class frmPetss
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
            this.txtPetID = new System.Windows.Forms.TextBox();
            this.lbPetName = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lbQuantityInStock = new System.Windows.Forms.Label();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbImportPrice = new System.Windows.Forms.Label();
            this.lbExportPrice = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.txtExportPrice = new System.Windows.Forms.TextBox();
            this.dgvPetList = new System.Windows.Forms.DataGridView();
            this.PetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbPetID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPetID
            // 
            this.txtPetID.Enabled = false;
            this.txtPetID.Location = new System.Drawing.Point(112, 17);
            this.txtPetID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(133, 22);
            this.txtPetID.TabIndex = 1003;
            this.txtPetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPetName
            // 
            this.lbPetName.AutoSize = true;
            this.lbPetName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPetName.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPetName.Location = new System.Drawing.Point(10, 63);
            this.lbPetName.Name = "lbPetName";
            this.lbPetName.Size = new System.Drawing.Size(86, 22);
            this.lbPetName.TabIndex = 1004;
            this.lbPetName.Text = "Pet name";
            // 
            // txtPetName
            // 
            this.txtPetName.Enabled = false;
            this.txtPetName.Location = new System.Drawing.Point(112, 65);
            this.txtPetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(133, 22);
            this.txtPetName.TabIndex = 1005;
            this.txtPetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAge.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbAge.Location = new System.Drawing.Point(10, 113);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(42, 22);
            this.lbAge.TabIndex = 1006;
            this.lbAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(112, 117);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(133, 22);
            this.txtAge.TabIndex = 1007;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGender
            // 
            this.txtGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(481, 17);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(133, 22);
            this.txtGender.TabIndex = 1008;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbGender
            // 
            this.lbGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGender.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbGender.Location = new System.Drawing.Point(348, 15);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(71, 22);
            this.lbGender.TabIndex = 1009;
            this.lbGender.Text = "Gender";
            // 
            // lbColor
            // 
            this.lbColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbColor.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbColor.Location = new System.Drawing.Point(348, 63);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(57, 22);
            this.lbColor.TabIndex = 1010;
            this.lbColor.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(481, 65);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(133, 22);
            this.txtColor.TabIndex = 1011;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbQuantityInStock
            // 
            this.lbQuantityInStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbQuantityInStock.AutoSize = true;
            this.lbQuantityInStock.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuantityInStock.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbQuantityInStock.Location = new System.Drawing.Point(348, 113);
            this.lbQuantityInStock.Name = "lbQuantityInStock";
            this.lbQuantityInStock.Size = new System.Drawing.Size(81, 22);
            this.lbQuantityInStock.TabIndex = 1012;
            this.lbQuantityInStock.Text = "Quantity";
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantityInStock.Enabled = false;
            this.txtQuantityInStock.Location = new System.Drawing.Point(481, 111);
            this.txtQuantityInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(133, 22);
            this.txtQuantityInStock.TabIndex = 1013;
            this.txtQuantityInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCategoryID.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbCategoryID.Location = new System.Drawing.Point(682, 18);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(112, 22);
            this.lbCategoryID.TabIndex = 1014;
            this.lbCategoryID.Text = "Category ID";
            // 
            // lbImportPrice
            // 
            this.lbImportPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbImportPrice.AutoSize = true;
            this.lbImportPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbImportPrice.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbImportPrice.Location = new System.Drawing.Point(683, 63);
            this.lbImportPrice.Name = "lbImportPrice";
            this.lbImportPrice.Size = new System.Drawing.Size(112, 22);
            this.lbImportPrice.TabIndex = 1015;
            this.lbImportPrice.Text = "Import price";
            // 
            // lbExportPrice
            // 
            this.lbExportPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExportPrice.AutoSize = true;
            this.lbExportPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbExportPrice.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbExportPrice.Location = new System.Drawing.Point(683, 115);
            this.lbExportPrice.Name = "lbExportPrice";
            this.lbExportPrice.Size = new System.Drawing.Size(112, 22);
            this.lbExportPrice.TabIndex = 1016;
            this.lbExportPrice.Text = "Export price";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryID.Enabled = false;
            this.txtCategoryID.Location = new System.Drawing.Point(811, 17);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(133, 22);
            this.txtCategoryID.TabIndex = 1017;
            this.txtCategoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImportPrice.Enabled = false;
            this.txtImportPrice.Location = new System.Drawing.Point(811, 65);
            this.txtImportPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(133, 22);
            this.txtImportPrice.TabIndex = 1018;
            this.txtImportPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExportPrice
            // 
            this.txtExportPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportPrice.Enabled = false;
            this.txtExportPrice.Location = new System.Drawing.Point(811, 115);
            this.txtExportPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExportPrice.Name = "txtExportPrice";
            this.txtExportPrice.Size = new System.Drawing.Size(133, 22);
            this.txtExportPrice.TabIndex = 1019;
            this.txtExportPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvPetList
            // 
            this.dgvPetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPetList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPetList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PetID,
            this.CategoryID,
            this.PetName,
            this.Age,
            this.Gender,
            this.Color,
            this.Quantity,
            this.ImportPrice,
            this.ExportPrice,
            this.Status});
            this.dgvPetList.Location = new System.Drawing.Point(12, 256);
            this.dgvPetList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPetList.Name = "dgvPetList";
            this.dgvPetList.RowHeadersWidth = 51;
            this.dgvPetList.RowTemplate.Height = 25;
            this.dgvPetList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPetList.Size = new System.Drawing.Size(822, 292);
            this.dgvPetList.TabIndex = 1020;
            this.dgvPetList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPetList_CellClick);
            // 
            // PetID
            // 
            this.PetID.DataPropertyName = "PetID";
            this.PetID.HeaderText = "Pet ID";
            this.PetID.MinimumWidth = 6;
            this.PetID.Name = "PetID";
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "Category";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            // 
            // PetName
            // 
            this.PetName.DataPropertyName = "PetName";
            this.PetName.HeaderText = "Pet Name";
            this.PetName.MinimumWidth = 6;
            this.PetName.Name = "PetName";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // ImportPrice
            // 
            this.ImportPrice.DataPropertyName = "ImportPrice";
            this.ImportPrice.HeaderText = "Import Price";
            this.ImportPrice.MinimumWidth = 6;
            this.ImportPrice.Name = "ImportPrice";
            // 
            // ExportPrice
            // 
            this.ExportPrice.DataPropertyName = "ExportPrice";
            this.ExportPrice.HeaderText = "Export Price";
            this.ExportPrice.MinimumWidth = 6;
            this.ExportPrice.Name = "ExportPrice";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(840, 256);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.Location = new System.Drawing.Point(840, 385);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(112, 166);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(133, 22);
            this.txtStatus.TabIndex = 1025;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPetID
            // 
            this.lbPetID.AutoSize = true;
            this.lbPetID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPetID.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPetID.Location = new System.Drawing.Point(12, 18);
            this.lbPetID.Name = "lbPetID";
            this.lbPetID.Size = new System.Drawing.Size(63, 22);
            this.lbPetID.TabIndex = 1028;
            this.lbPetID.Text = "Pet ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdate.Location = new System.Drawing.Point(840, 320);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(481, 211);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(133, 23);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbStatus.Location = new System.Drawing.Point(12, 164);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(61, 22);
            this.lbStatus.TabIndex = 1024;
            this.lbStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(348, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 1030;
            this.label1.Text = "Category";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(112, 217);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Pet name...";
            this.txtSearch.Size = new System.Drawing.Size(133, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSearch.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbSearch.Location = new System.Drawing.Point(12, 217);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(67, 22);
            this.lbSearch.TabIndex = 1024;
            this.lbSearch.Text = "Search";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnLoad.Location = new System.Drawing.Point(840, 454);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(113, 45);
            this.btnLoad.TabIndex = 1031;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmPetss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lbPetID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPetList);
            this.Controls.Add(this.txtExportPrice);
            this.Controls.Add(this.txtImportPrice);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.lbExportPrice);
            this.Controls.Add(this.lbImportPrice);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.lbQuantityInStock);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.lbPetName);
            this.Controls.Add(this.txtPetID);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "frmPetss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.frmPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPetID;
        private System.Windows.Forms.Label lbPetName;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lbQuantityInStock;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbImportPrice;
        private System.Windows.Forms.Label lbExportPrice;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.TextBox txtExportPrice;
        private System.Windows.Forms.DataGridView dgvPetList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lbPetID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExportPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnLoad;
    }
}