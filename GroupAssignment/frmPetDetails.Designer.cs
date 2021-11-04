
namespace WinformPetStore
{
    partial class frmPetDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPetDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtExport = new System.Windows.Forms.MaskedTextBox();
            this.txtImport = new System.Windows.Forms.MaskedTextBox();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbCate = new System.Windows.Forms.Label();
            this.lbExport = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbImport = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lbPetName = new System.Windows.Forms.Label();
            this.txtPetID = new System.Windows.Forms.TextBox();
            this.lbCusID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 90);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbTitle.Location = new System.Drawing.Point(244, 47);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(234, 36);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Pet information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(55)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.txtExport);
            this.panel2.Controls.Add(this.txtImport);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.cboGender);
            this.panel2.Controls.Add(this.cboCate);
            this.panel2.Controls.Add(this.txtColor);
            this.panel2.Controls.Add(this.lbQuantity);
            this.panel2.Controls.Add(this.lbCate);
            this.panel2.Controls.Add(this.lbExport);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.lbImport);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPetName);
            this.panel2.Controls.Add(this.lbPetName);
            this.panel2.Controls.Add(this.txtPetID);
            this.panel2.Controls.Add(this.lbCusID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 479);
            this.panel2.TabIndex = 3;
            // 
            // txtExport
            // 
            this.txtExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtExport.Location = new System.Drawing.Point(509, 212);
            this.txtExport.Mask = "000000000";
            this.txtExport.Name = "txtExport";
            this.txtExport.Size = new System.Drawing.Size(100, 22);
            this.txtExport.TabIndex = 8;
            this.txtExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImport
            // 
            this.txtImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtImport.Location = new System.Drawing.Point(162, 212);
            this.txtImport.Mask = "000000000";
            this.txtImport.Name = "txtImport";
            this.txtImport.Size = new System.Drawing.Size(100, 22);
            this.txtImport.TabIndex = 8;
            this.txtImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAge.Location = new System.Drawing.Point(509, 95);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(120, 22);
            this.txtAge.TabIndex = 7;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantity.Location = new System.Drawing.Point(162, 286);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 22);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboGender
            // 
            this.cboGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(162, 152);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(102, 23);
            this.cboGender.TabIndex = 2;
            // 
            // cboCate
            // 
            this.cboCate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Rabbit",
            "Hamster",
            "Hedgehog"});
            this.cboCate.Location = new System.Drawing.Point(509, 38);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(102, 23);
            this.cboCate.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtColor.Location = new System.Drawing.Point(509, 156);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(174, 22);
            this.txtColor.TabIndex = 6;
            // 
            // lbQuantity
            // 
            this.lbQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuantity.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbQuantity.Location = new System.Drawing.Point(12, 285);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(67, 19);
            this.lbQuantity.TabIndex = 7;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbCate
            // 
            this.lbCate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCate.AutoSize = true;
            this.lbCate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCate.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbCate.Location = new System.Drawing.Point(404, 38);
            this.lbCate.Name = "lbCate";
            this.lbCate.Size = new System.Drawing.Size(71, 19);
            this.lbCate.TabIndex = 7;
            this.lbCate.Text = "Category";
            // 
            // lbExport
            // 
            this.lbExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbExport.AutoSize = true;
            this.lbExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbExport.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbExport.Location = new System.Drawing.Point(404, 212);
            this.lbExport.Name = "lbExport";
            this.lbExport.Size = new System.Drawing.Size(92, 19);
            this.lbExport.TabIndex = 7;
            this.lbExport.Text = "Export Price";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SandyBrown;
            this.label5.Location = new System.Drawing.Point(404, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Color";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(404, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCancel.Location = new System.Drawing.Point(386, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSave.Location = new System.Drawing.Point(209, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 52);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbImport
            // 
            this.lbImport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbImport.AutoSize = true;
            this.lbImport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbImport.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbImport.Location = new System.Drawing.Point(12, 212);
            this.lbImport.Name = "lbImport";
            this.lbImport.Size = new System.Drawing.Size(92, 19);
            this.lbImport.TabIndex = 7;
            this.lbImport.Text = "Import Price";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gender";
            // 
            // txtPetName
            // 
            this.txtPetName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPetName.Location = new System.Drawing.Point(162, 94);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(174, 22);
            this.txtPetName.TabIndex = 3;
            // 
            // lbPetName
            // 
            this.lbPetName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPetName.AutoSize = true;
            this.lbPetName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPetName.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbPetName.Location = new System.Drawing.Point(12, 94);
            this.lbPetName.Name = "lbPetName";
            this.lbPetName.Size = new System.Drawing.Size(75, 19);
            this.lbPetName.TabIndex = 7;
            this.lbPetName.Text = "Pet Name";
            // 
            // txtPetID
            // 
            this.txtPetID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPetID.Enabled = false;
            this.txtPetID.Location = new System.Drawing.Point(162, 38);
            this.txtPetID.Name = "txtPetID";
            this.txtPetID.Size = new System.Drawing.Size(76, 22);
            this.txtPetID.TabIndex = 1;
            this.txtPetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCusID
            // 
            this.lbCusID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCusID.AutoSize = true;
            this.lbCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCusID.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbCusID.Location = new System.Drawing.Point(12, 38);
            this.lbCusID.Name = "lbCusID";
            this.lbCusID.Size = new System.Drawing.Size(53, 19);
            this.lbCusID.TabIndex = 7;
            this.lbCusID.Text = "Pet ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 6;
            // 
            // frmPetDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(714, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MinimumSize = new System.Drawing.Size(730, 630);
            this.Name = "frmPetDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPetDetails_FormClosing);
            this.Load += new System.EventHandler(this.frmPetDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.TextBox txtPetID;
        private System.Windows.Forms.Label lbCusID;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lbPetName;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbCate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox txtExport;
        private System.Windows.Forms.MaskedTextBox txtImport;
        private System.Windows.Forms.NumericUpDown txtAge;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lbExport;
        private System.Windows.Forms.Label lbImport;
    }
}