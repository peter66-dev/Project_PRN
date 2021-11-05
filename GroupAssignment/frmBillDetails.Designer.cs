
namespace GroupAssignment
{
    partial class frmBillDetails
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
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.PetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPetInfo = new System.Windows.Forms.Label();
            this.txtPetID = new System.Windows.Forms.TextBox();
            this.lbPetID = new System.Windows.Forms.Label();
            this.txtPetAge = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lbPetName = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lbPetGender = new System.Windows.Forms.Label();
            this.lbQuantityBuy = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbCalculation = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lbGrandTotal = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lbPaidAmount = new System.Windows.Forms.Label();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.lbReturnAmount = new System.Windows.Forms.Label();
            this.lbQuantityInStock = new System.Windows.Forms.Label();
            this.txtQuantityBuy = new System.Windows.Forms.NumericUpDown();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.lbVND = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbFreight = new System.Windows.Forms.Label();
            this.cboCusGender = new System.Windows.Forms.ComboBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCusGender = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbCusInfo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbPoint = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.lbCusName = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PetID,
            this.PetName,
            this.Gender,
            this.QuantityBuy,
            this.Price});
            this.dgvCart.Enabled = false;
            this.dgvCart.Location = new System.Drawing.Point(12, 243);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowTemplate.Height = 25;
            this.dgvCart.Size = new System.Drawing.Size(580, 289);
            this.dgvCart.TabIndex = 100;
            // 
            // PetID
            // 
            this.PetID.HeaderText = "Pet ID";
            this.PetID.Name = "PetID";
            // 
            // PetName
            // 
            this.PetName.HeaderText = "Pet name";
            this.PetName.Name = "PetName";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // QuantityBuy
            // 
            this.QuantityBuy.HeaderText = "Quantity buy";
            this.QuantityBuy.Name = "QuantityBuy";
            // 
            // Price
            // 
            this.Price.HeaderText = "Unit price (VND)";
            this.Price.Name = "Price";
            // 
            // lbPetInfo
            // 
            this.lbPetInfo.AutoSize = true;
            this.lbPetInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPetInfo.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPetInfo.Location = new System.Drawing.Point(12, 111);
            this.lbPetInfo.Name = "lbPetInfo";
            this.lbPetInfo.Size = new System.Drawing.Size(137, 22);
            this.lbPetInfo.TabIndex = 100;
            this.lbPetInfo.Text = "Pet information";
            // 
            // txtPetID
            // 
            this.txtPetID.Location = new System.Drawing.Point(113, 151);
            this.txtPetID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(133, 22);
            this.txtPetID.TabIndex = 2;
            this.txtPetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPetID.TextChanged += new System.EventHandler(this.txtPetID_TextChanged);
            // 
            // lbPetID
            // 
            this.lbPetID.AutoSize = true;
            this.lbPetID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPetID.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPetID.Location = new System.Drawing.Point(12, 151);
            this.lbPetID.Name = "lbPetID";
            this.lbPetID.Size = new System.Drawing.Size(41, 15);
            this.lbPetID.TabIndex = 333;
            this.lbPetID.Text = "Pet ID";
            // 
            // txtPetAge
            // 
            this.txtPetAge.Enabled = false;
            this.txtPetAge.Location = new System.Drawing.Point(113, 179);
            this.txtPetAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPetAge.Name = "txtPetAge";
            this.txtPetAge.Size = new System.Drawing.Size(133, 22);
            this.txtPetAge.TabIndex = 100;
            this.txtPetAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAge.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbAge.Location = new System.Drawing.Point(12, 180);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(29, 15);
            this.lbAge.TabIndex = 333;
            this.lbAge.Text = "Age";
            // 
            // txtPetName
            // 
            this.txtPetName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPetName.Enabled = false;
            this.txtPetName.Location = new System.Drawing.Point(449, 148);
            this.txtPetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(143, 22);
            this.txtPetName.TabIndex = 100;
            this.txtPetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPetName
            // 
            this.lbPetName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPetName.AutoSize = true;
            this.lbPetName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPetName.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPetName.Location = new System.Drawing.Point(329, 151);
            this.lbPetName.Name = "lbPetName";
            this.lbPetName.Size = new System.Drawing.Size(57, 15);
            this.lbPetName.TabIndex = 333;
            this.lbPetName.Text = "Pet name";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(449, 176);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(143, 22);
            this.txtUnitPrice.TabIndex = 100;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbUnitPrice.Location = new System.Drawing.Point(329, 180);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(61, 15);
            this.lbUnitPrice.TabIndex = 333;
            this.lbUnitPrice.Text = "Unit price";
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(113, 206);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(133, 22);
            this.txtGender.TabIndex = 100;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPetGender
            // 
            this.lbPetGender.AutoSize = true;
            this.lbPetGender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPetGender.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPetGender.Location = new System.Drawing.Point(12, 207);
            this.lbPetGender.Name = "lbPetGender";
            this.lbPetGender.Size = new System.Drawing.Size(47, 15);
            this.lbPetGender.TabIndex = 333;
            this.lbPetGender.Text = "Gender";
            // 
            // lbQuantityBuy
            // 
            this.lbQuantityBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantityBuy.AutoSize = true;
            this.lbQuantityBuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuantityBuy.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbQuantityBuy.Location = new System.Drawing.Point(633, 184);
            this.lbQuantityBuy.Name = "lbQuantityBuy";
            this.lbQuantityBuy.Size = new System.Drawing.Size(77, 15);
            this.lbQuantityBuy.TabIndex = 3;
            this.lbQuantityBuy.Text = "Quantity buy";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Location = new System.Drawing.Point(872, 80);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSave.Location = new System.Drawing.Point(754, 486);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 46);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbCalculation
            // 
            this.lbCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCalculation.AutoSize = true;
            this.lbCalculation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCalculation.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbCalculation.Location = new System.Drawing.Point(635, 221);
            this.lbCalculation.Name = "lbCalculation";
            this.lbCalculation.Size = new System.Drawing.Size(162, 22);
            this.lbCalculation.TabIndex = 100;
            this.lbCalculation.Text = "Calculation details";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(754, 258);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(153, 22);
            this.txtSubTotal.TabIndex = 100;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubTotal.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbSubTotal.Location = new System.Drawing.Point(635, 261);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(55, 15);
            this.lbSubTotal.TabIndex = 333;
            this.lbSubTotal.Text = "Sub total";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Location = new System.Drawing.Point(754, 295);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(153, 22);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDiscount.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbDiscount.Location = new System.Drawing.Point(635, 296);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(56, 15);
            this.lbDiscount.TabIndex = 333;
            this.lbDiscount.Text = "Discount";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(754, 368);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(153, 22);
            this.txtGrandTotal.TabIndex = 100;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbGrandTotal
            // 
            this.lbGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGrandTotal.AutoSize = true;
            this.lbGrandTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGrandTotal.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbGrandTotal.Location = new System.Drawing.Point(635, 369);
            this.lbGrandTotal.Name = "lbGrandTotal";
            this.lbGrandTotal.Size = new System.Drawing.Size(68, 15);
            this.lbGrandTotal.TabIndex = 333;
            this.lbGrandTotal.Text = "Grand total";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaidAmount.Location = new System.Drawing.Point(754, 408);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(153, 22);
            this.txtPaidAmount.TabIndex = 7;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbPaidAmount
            // 
            this.lbPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPaidAmount.AutoSize = true;
            this.lbPaidAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPaidAmount.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPaidAmount.Location = new System.Drawing.Point(635, 410);
            this.lbPaidAmount.Name = "lbPaidAmount";
            this.lbPaidAmount.Size = new System.Drawing.Size(74, 15);
            this.lbPaidAmount.TabIndex = 333;
            this.lbPaidAmount.Text = "Paid amount";
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReturnAmount.Enabled = false;
            this.txtReturnAmount.Location = new System.Drawing.Point(754, 445);
            this.txtReturnAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.Size = new System.Drawing.Size(153, 22);
            this.txtReturnAmount.TabIndex = 933;
            this.txtReturnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbReturnAmount
            // 
            this.lbReturnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReturnAmount.AutoSize = true;
            this.lbReturnAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbReturnAmount.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbReturnAmount.Location = new System.Drawing.Point(635, 444);
            this.lbReturnAmount.Name = "lbReturnAmount";
            this.lbReturnAmount.Size = new System.Drawing.Size(89, 15);
            this.lbReturnAmount.TabIndex = 333;
            this.lbReturnAmount.Text = "Return amount";
            // 
            // lbQuantityInStock
            // 
            this.lbQuantityInStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbQuantityInStock.AutoSize = true;
            this.lbQuantityInStock.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuantityInStock.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbQuantityInStock.Location = new System.Drawing.Point(329, 211);
            this.lbQuantityInStock.Name = "lbQuantityInStock";
            this.lbQuantityInStock.Size = new System.Drawing.Size(102, 15);
            this.lbQuantityInStock.TabIndex = 333;
            this.lbQuantityInStock.Text = "Quantity in stock";
            // 
            // txtQuantityBuy
            // 
            this.txtQuantityBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantityBuy.Location = new System.Drawing.Point(754, 182);
            this.txtQuantityBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantityBuy.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtQuantityBuy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantityBuy.Name = "txtQuantityBuy";
            this.txtQuantityBuy.Size = new System.Drawing.Size(120, 22);
            this.txtQuantityBuy.TabIndex = 3;
            this.txtQuantityBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantityBuy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantityInStock.Enabled = false;
            this.txtQuantityInStock.Location = new System.Drawing.Point(449, 203);
            this.txtQuantityInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(143, 22);
            this.txtQuantityInStock.TabIndex = 100;
            this.txtQuantityInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbVND
            // 
            this.lbVND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVND.AutoSize = true;
            this.lbVND.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbVND.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbVND.Location = new System.Drawing.Point(803, 223);
            this.lbVND.Name = "lbVND";
            this.lbVND.Size = new System.Drawing.Size(56, 19);
            this.lbVND.TabIndex = 933;
            this.lbVND.Text = "(VND)";
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCheck.Location = new System.Drawing.Point(635, 486);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(88, 46);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtFreight
            // 
            this.txtFreight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFreight.Location = new System.Drawing.Point(754, 330);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(153, 22);
            this.txtFreight.TabIndex = 6;
            this.txtFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbFreight
            // 
            this.lbFreight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFreight.AutoSize = true;
            this.lbFreight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFreight.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbFreight.Location = new System.Drawing.Point(635, 332);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(48, 15);
            this.lbFreight.TabIndex = 333;
            this.lbFreight.Text = "Freight";
            // 
            // cboCusGender
            // 
            this.cboCusGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCusGender.Enabled = false;
            this.cboCusGender.FormattingEnabled = true;
            this.cboCusGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboCusGender.Location = new System.Drawing.Point(754, 73);
            this.cboCusGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCusGender.Name = "cboCusGender";
            this.cboCusGender.Size = new System.Drawing.Size(83, 23);
            this.cboCusGender.TabIndex = 4444;
            // 
            // lbAddress
            // 
            this.lbAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddress.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbAddress.Location = new System.Drawing.Point(329, 72);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(52, 15);
            this.lbAddress.TabIndex = 333;
            this.lbAddress.Text = "Address";
            // 
            // lbCusGender
            // 
            this.lbCusGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCusGender.AutoSize = true;
            this.lbCusGender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCusGender.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbCusGender.Location = new System.Drawing.Point(636, 75);
            this.lbCusGender.Name = "lbCusGender";
            this.lbCusGender.Size = new System.Drawing.Size(47, 15);
            this.lbCusGender.TabIndex = 1000;
            this.lbCusGender.Text = "Gender";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbEmail.Location = new System.Drawing.Point(12, 45);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(38, 15);
            this.lbEmail.TabIndex = 1000;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPhone.Location = new System.Drawing.Point(329, 45);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(41, 15);
            this.lbPhone.TabIndex = 333;
            this.lbPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 38);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(449, 41);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(143, 22);
            this.txtPhone.TabIndex = 3333;
            // 
            // lbCusInfo
            // 
            this.lbCusInfo.AutoSize = true;
            this.lbCusInfo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCusInfo.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbCusInfo.Location = new System.Drawing.Point(12, 9);
            this.lbCusInfo.Name = "lbCusInfo";
            this.lbCusInfo.Size = new System.Drawing.Size(239, 26);
            this.lbCusInfo.TabIndex = 1000;
            this.lbCusInfo.Text = "Customer information";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(449, 72);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(143, 53);
            this.txtAddress.TabIndex = 42333;
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(754, 151);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(120, 22);
            this.txtColor.TabIndex = 100;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbColor
            // 
            this.lbColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbColor.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbColor.Location = new System.Drawing.Point(635, 154);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(38, 15);
            this.lbColor.TabIndex = 333;
            this.lbColor.Text = "Color";
            // 
            // lbPoint
            // 
            this.lbPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPoint.AutoSize = true;
            this.lbPoint.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPoint.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPoint.Location = new System.Drawing.Point(634, 45);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(36, 15);
            this.lbPoint.TabIndex = 333;
            this.lbPoint.Text = "Point";
            // 
            // txtPoint
            // 
            this.txtPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoint.Enabled = false;
            this.txtPoint.Location = new System.Drawing.Point(754, 41);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(83, 22);
            this.txtPoint.TabIndex = 2333;
            this.txtPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCusName
            // 
            this.lbCusName.AutoSize = true;
            this.lbCusName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCusName.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbCusName.Location = new System.Drawing.Point(12, 76);
            this.lbCusName.Name = "lbCusName";
            this.lbCusName.Size = new System.Drawing.Size(93, 15);
            this.lbCusName.TabIndex = 1000;
            this.lbCusName.Text = "Customer name";
            // 
            // txtCusName
            // 
            this.txtCusName.Enabled = false;
            this.txtCusName.Location = new System.Drawing.Point(113, 69);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(181, 22);
            this.txtCusName.TabIndex = 1333;
            // 
            // frmBillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.lbCusInfo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbVND);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbCusName);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtQuantityBuy);
            this.Controls.Add(this.lbCusGender);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboCusGender);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbReturnAmount);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbPaidAmount);
            this.Controls.Add(this.lbGrandTotal);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.lbQuantityBuy);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbQuantityInStock);
            this.Controls.Add(this.lbPetGender);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbPetName);
            this.Controls.Add(this.lbPetID);
            this.Controls.Add(this.txtReturnAmount);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPetAge);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.txtPetID);
            this.Controls.Add(this.lbCalculation);
            this.Controls.Add(this.lbPetInfo);
            this.Controls.Add(this.dgvCart);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "frmBillDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create bill";
            this.Load += new System.EventHandler(this.frmBillDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lbPetInfo;
        private System.Windows.Forms.TextBox txtPetID;
        private System.Windows.Forms.Label lbPetID;
        private System.Windows.Forms.TextBox txtPetAge;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lbPetName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lbPetGender;
        private System.Windows.Forms.Label lbQuantityBuy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbCalculation;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label lbGrandTotal;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label lbPaidAmount;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.Label lbReturnAmount;
        private System.Windows.Forms.Label lbQuantityInStock;
        private System.Windows.Forms.NumericUpDown txtQuantityBuy;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Label lbVND;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.ComboBox cboCusGender;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbCusGender;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbCusInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label lbCusName;
        private System.Windows.Forms.TextBox txtCusName;
    }
}