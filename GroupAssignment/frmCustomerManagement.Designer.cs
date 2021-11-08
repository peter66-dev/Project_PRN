using System;
using System.Windows.Forms;

namespace WinformPetStore
{
    partial class frmCustomerManagement
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
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccumulatedPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtEmailSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.lbPoint = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.lbCustomerID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.Gender,
            this.Email,
            this.Phone,
            this.Address,
            this.AccumulatedPoint,
            this.Status});
            this.dgvCustomerList.Location = new System.Drawing.Point(0, 286);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.RowTemplate.Height = 25;
            this.dgvCustomerList.Size = new System.Drawing.Size(1054, 325);
            this.dgvCustomerList.TabIndex = 999;
            this.dgvCustomerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // AccumulatedPoint
            // 
            this.AccumulatedPoint.DataPropertyName = "AccumulatedPoint";
            this.AccumulatedPoint.HeaderText = "Point";
            this.AccumulatedPoint.Name = "AccumulatedPoint";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnLoad.Location = new System.Drawing.Point(956, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 38);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(956, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdate.Location = new System.Drawing.Point(956, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.Location = new System.Drawing.Point(956, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSort.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSort.Location = new System.Drawing.Point(851, 248);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(191, 35);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "SORT BY NAME";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtEmailSearch
            // 
            this.txtEmailSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailSearch.Location = new System.Drawing.Point(107, 254);
            this.txtEmailSearch.Name = "txtEmailSearch";
            this.txtEmailSearch.PlaceholderText = "Input Email";
            this.txtEmailSearch.Size = new System.Drawing.Size(137, 25);
            this.txtEmailSearch.TabIndex = 6;
            this.txtEmailSearch.TextChanged += new System.EventHandler(this.txtEmailSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSearch.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbSearch.Location = new System.Drawing.Point(16, 254);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(67, 22);
            this.lbSearch.TabIndex = 1000;
            this.lbSearch.Text = "Search";
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPhone.Location = new System.Drawing.Point(528, 114);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(61, 22);
            this.lbPhone.TabIndex = 1001;
            this.lbPhone.Text = "Phone";
            // 
            // cboGender
            // 
            this.cboGender.Enabled = false;
            this.cboGender.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(172, 117);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(202, 25);
            this.cboGender.TabIndex = 1003;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGender.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbGender.Location = new System.Drawing.Point(9, 115);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(71, 22);
            this.lbGender.TabIndex = 1002;
            this.lbGender.Text = "Gender";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(617, 112);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(202, 25);
            this.txtPhone.TabIndex = 1004;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(617, 167);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(202, 47);
            this.txtAddress.TabIndex = 1005;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(617, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 25);
            this.txtEmail.TabIndex = 1006;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbAddress
            // 
            this.lbAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddress.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbAddress.Location = new System.Drawing.Point(528, 169);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(76, 22);
            this.lbAddress.TabIndex = 1007;
            this.lbAddress.Text = "Address";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbEmail.Location = new System.Drawing.Point(528, 15);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(58, 22);
            this.lbEmail.TabIndex = 1008;
            this.lbEmail.Text = "Email";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(617, 64);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(202, 25);
            this.txtStatus.TabIndex = 1009;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbStatus.Location = new System.Drawing.Point(528, 67);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(61, 22);
            this.lbStatus.TabIndex = 1010;
            this.lbStatus.Text = "Status";
            // 
            // txtPoint
            // 
            this.txtPoint.Enabled = false;
            this.txtPoint.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoint.Location = new System.Drawing.Point(172, 169);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.ReadOnly = true;
            this.txtPoint.Size = new System.Drawing.Size(202, 25);
            this.txtPoint.TabIndex = 1011;
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPoint.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPoint.Location = new System.Drawing.Point(9, 170);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(53, 22);
            this.lbPoint.TabIndex = 1012;
            this.lbPoint.Text = "Point";
            // 
            // txtCusName
            // 
            this.txtCusName.Enabled = false;
            this.txtCusName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCusName.Location = new System.Drawing.Point(172, 66);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.ReadOnly = true;
            this.txtCusName.Size = new System.Drawing.Size(202, 25);
            this.txtCusName.TabIndex = 1013;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerName.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbCustomerName.Location = new System.Drawing.Point(9, 67);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(143, 22);
            this.lbCustomerName.TabIndex = 1014;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // txtCusID
            // 
            this.txtCusID.Enabled = false;
            this.txtCusID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCusID.Location = new System.Drawing.Point(172, 16);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.ReadOnly = true;
            this.txtCusID.Size = new System.Drawing.Size(202, 25);
            this.txtCusID.TabIndex = 1015;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerID.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbCustomerID.Location = new System.Drawing.Point(9, 16);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(116, 22);
            this.lbCustomerID.TabIndex = 1016;
            this.lbCustomerID.Text = "Customer ID";
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1054, 611);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.lbCustomerID);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtEmailSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvCustomerList);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1070, 650);
            this.Name = "frmCustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txtEmailSearch;
        private Label lbSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn AccumulatedPoint;
        private DataGridViewTextBoxColumn Status;
        private Label lbPhone;
        private ComboBox cboGender;
        private Label lbGender;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label lbAddress;
        private Label lbEmail;
        private TextBox txtStatus;
        private Label lbStatus;
        private TextBox txtPoint;
        private Label lbPoint;
        private TextBox txtCusName;
        private Label lbCustomerName;
        private TextBox txtCusID;
        private Label lbCustomerID;
    }
}