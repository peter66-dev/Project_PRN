using Business_Object;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GroupAssignment
{
    public partial class frmBillDetails : Form
    {
        public IPetRepository petRepository = new PetRepository();
        public IBillRepository billRepository = new BillRepository();
        public IBillDetailRepository billDetailRepository = new BillDetailRepository();
        public ICustomerRepository cusRepository = new CustomerRepository();
        List<PetObject> cart = new List<PetObject>();
        int check = 0;
        public frmBillDetails()
        {
            if (Program.isLogin)
            {
                InitializeComponent();
            }
            else
            {
                Application.Restart();
            }
        }

        private void frmBillDetails_Load(object sender, EventArgs e)
        {
            //btnAdd.Enabled = false;
            btnCheck.Enabled = false;
            btnSave.Enabled = false;
            txtEmail.Focus();
        }
        void AddToCart(PetObject pet)
        {
            bool checkExist = false;
            foreach (var p in cart)
            {
                if (p.PetID == pet.PetID)
                {
                    p.QuantityInStock += pet.QuantityInStock;// chỗ này là tổng số lượng mua nha
                    checkExist = true;
                }
            }
            if (!checkExist)
            {
                cart.Add(pet);
            }
        }
        void ClearPetInfor()
        {
            txtPetName.Clear();
            txtCusName.Clear();
            txtColor.Clear();
            txtPetAge.Clear();
            txtGender.Clear();
            txtQuantityInStock.Clear();
            txtUnitPrice.Clear();
        }

        private bool CheckCustomerInfo()
        {
            bool check = true;
            if (txtPhone.Text.Trim().Length == 0)
            {
                check = false;
                MessageBox.Show("Sorry, you must fill in Email information before adding pet please!", "Check form customer message", MessageBoxButtons.OK);
                txtEmail.Focus();
            }
            return check;
        }
        private void BlockCustomerInfo()
        {
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            cboCusGender.Enabled = false;
            //txtEmail.Enabled = false;
        }

        private bool CheckFormCalculation()
        {
            bool check = true;
            try
            {
                if (!(float.TryParse(txtDiscount.Text, out float discount) && (discount >= 0 && discount < 1)))
                {
                    txtDiscount.Focus();
                    check = false;
                    MessageBox.Show("Sorry, discount must be in [0-1) please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else if (!(decimal.TryParse(txtFreight.Text, out decimal valuee) && (valuee >= 0 && valuee <= 1000000)))
                {
                    txtFreight.Focus();
                    check = false;
                    MessageBox.Show("Sorry, Freight must be in [0-1000000] VND!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else if (!(decimal.TryParse(txtPaidAmount.Text, out decimal paid) && paid > 0))
                {
                    txtPaidAmount.Focus();
                    check = false;
                    MessageBox.Show("Sorry, Paid Amount must be in positive number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else
                {
                    decimal paidAmount = decimal.Parse(txtPaidAmount.Text);
                    decimal freight = decimal.Parse(txtFreight.Text);
                    decimal grandTotal = Math.Round(GrandTotal(float.Parse(txtDiscount.Text)), 2);
                    if (!(paidAmount - grandTotal - freight >= 0))
                    {
                        check = false;
                        txtPaidAmount.Focus();
                        MessageBox.Show($"Paid Amount: {paidAmount} is not enough for this bill value:\n" +
                            $"{grandTotal} + {freight} = {grandTotal + freight}!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSave.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return check;
        }

        private bool CheckFormCalculation0()
        {
            bool check = true;
            try
            {
                if (!(float.TryParse(txtDiscount.Text, out float discount) && (discount >= 0 && discount < 1)))
                {
                    txtDiscount.Focus();
                    check = false;
                    MessageBox.Show("Sorry, discount must be in [0-1) please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else if (!(decimal.TryParse(txtFreight.Text, out decimal valuee) && (valuee >= 0 && valuee <= 1000000)))
                {
                    txtFreight.Focus();
                    check = false;
                    MessageBox.Show("Sorry, Freight must be in [0-1000000] VND!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }
            return check;
        }

        private bool CheckFormCalculation1()
        {
            bool check = true;
            try
            {
                if (!(decimal.TryParse(txtPaidAmount.Text, out decimal paid) && paid > 0))
                {
                    txtPaidAmount.Focus();
                    check = false;
                    MessageBox.Show("Sorry, Paid Amount must be in positive number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else
                {
                    decimal paidAmount = decimal.Parse(txtPaidAmount.Text);
                    decimal freight = decimal.Parse(txtFreight.Text);
                    decimal grandTotal = Math.Round(GrandTotal(float.Parse(txtDiscount.Text)), 2);
                    if (!(paidAmount - grandTotal - freight >= 0))
                    {
                        check = false;
                        txtPaidAmount.Focus();
                        MessageBox.Show($"Paid Amount: {paidAmount} is not enough for this bill value:\n{grandTotal} + {freight} = {grandTotal + freight}!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSave.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return check;
        }

        private decimal GrandTotal(float discount) => (decimal)(SubTotal() * (1 - discount));

        private double SubTotal()
        {
            double result = 0;
            foreach (var pet in cart)
            {
                result += (double)(pet.ExportPrice * pet.QuantityInStock);
            }
            return Math.Round(result, 2);
        }
        void ClearCustomerInfo()
        {
            txtPoint.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cboCusGender.Text = "";
        }
        private void LoadPetList()
        {
            try
            {
                if (cart.Count >= 1)
                {
                    dgvCart.Rows.Clear();
                    foreach (var pet in cart)
                    {
                        string gender = pet.Gender ? "Male" : " Female";
                        dgvCart.Rows.Add(pet.PetID, pet.PetName, gender, pet.QuantityInStock, Math.Round(pet.ExportPrice, 2));
                    }
                }
                dgvCart.Columns["PetID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCart.Columns["PetName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCart.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCart.Columns["QuantityBuy"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCart.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvCart.Columns["PetID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCart.Columns["PetName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCart.Columns["Gender"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCart.Columns["QuantityBuy"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCart.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCart.Columns["PetID"].ReadOnly = true;
                dgvCart.Columns["PetName"].ReadOnly = true;
                dgvCart.Columns["Gender"].ReadOnly = true;
                dgvCart.Columns["QuantityBuy"].ReadOnly = true;
                dgvCart.Columns["Price"].ReadOnly = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckCustomerInfo())
                {
                    BlockCustomerInfo();
                    if (txtQuantityBuy.Value > int.Parse(txtQuantityInStock.Text))
                    {
                        MessageBox.Show("Sorry, this pet's quantity don't have enough for you!", "Information", MessageBoxButtons.OK);
                    }
                    else
                    {
                        bool gender = cboCusGender.Text.Equals("Male") ? true : false;

                        PetObject pet = new PetObject(int.Parse(txtPetID.Text), txtPetName.Text.Trim(), txtColor.Text, int.Parse(txtPetAge.Text),
                            decimal.Parse(txtUnitPrice.Text), gender, Decimal.ToInt32(txtQuantityBuy.Value));
                        AddToCart(pet);
                        LoadPetList();
                        txtSubTotal.Text = SubTotal().ToString();
                        btnCheck.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            {/*
            if (CheckFormCalculation())
            {
                txtGrandTotal.Text = Math.Round(GrandTotal(float.Parse(txtDiscount.Text)), 2).ToString();
                btnAdd.Enabled = false;
                btnAdd.BackColor = Color.LightGray;
                double returnAmount = double.Parse(txtPaidAmount.Text) - double.Parse(txtGrandTotal.Text) - (double)decimal.Parse(txtFreight.Text);
                txtReturnAmount.Text = Math.Round(returnAmount, 2).ToString();


                //Check quantity in stock!
                List<string> checkQuantityPet = petRepository.CheckQuantity(cart);
                if (checkQuantityPet.Count == 0) // Check đủ -> ko add thêm , tiến hành add bill | bill detail -> btnSave_Click
                {
                    btnSave.Enabled = true;
                    btnSave.BackColor = Color.DeepSkyBlue;
                    MessageBox.Show($"Quantity in stock is enough for this bill\n" +
                        $"Please check bill carefully before save!", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    btnSave.Enabled = false;
                    string msg = "";
                    foreach (string str in checkQuantityPet)
                    {
                        msg += str + " | ";
                    }
                    MessageBox.Show($"Sorry, we don't have enough quantity for pets name: {msg}.\n" +
                        $"Please cancel this bill!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */
            }
            if (check == 0)
            {
                if (CheckFormCalculation0())
                {
                    txtGrandTotal.Text = Math.Round(GrandTotal(float.Parse(txtDiscount.Text)) + decimal.Parse(txtFreight.Text), 2).ToString();
                    btnAdd.Enabled = false;
                    btnAdd.BackColor = Color.LightGray;

                    List<string> checkQuantityPet = petRepository.CheckQuantity(cart);
                    if (checkQuantityPet.Count == 0)
                    {
                        MessageBox.Show($"Quantity in stock is enough for this bill\n" +
                            $"Please check bill carefully before saving!", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        btnSave.Enabled = false;
                        string msg = "";
                        foreach (string str in checkQuantityPet)
                        {
                            msg += str + " | ";
                        }
                        MessageBox.Show($"Sorry, we don't have enough quantity for pets name: {msg}.\n" +
                            $"Please cancel this bill!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ++check;
                }
            }
            else if (check == 1)
            {
                if (CheckFormCalculation1())
                {
                    txtGrandTotal.Text = Math.Round(GrandTotal(float.Parse(txtDiscount.Text)) + decimal.Parse(txtFreight.Text), 2).ToString();
                    double returnAmount = double.Parse(txtPaidAmount.Text) - double.Parse(txtGrandTotal.Text) - (double)decimal.Parse(txtFreight.Text);
                    txtReturnAmount.Text = Math.Round(returnAmount, 2).ToString();
                    btnSave.Enabled = true;
                    btnSave.BackColor = Color.DeepSkyBlue;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckFormCalculation())
            {
                CustomerObject cus = cusRepository.GetACustomerByPhone(txtPhone.Text.Trim());

                int countingbills = 5 + billRepository.GetTotalBill();
                // có khóa là int KHÔNG TỰ TĂNG nên phải đếm số lượng rồi +5 làm khóa
                decimal freight = Math.Round(decimal.Parse(txtFreight.Text), 2);
                double total = Math.Round(double.Parse(txtGrandTotal.Text), 2);
                billRepository.InsertBill(countingbills, cus.CustomerID, (decimal)total, freight); // freight là phí ship!
                //add new bill details
                foreach (var pet in cart)
                {
                    BillDetailObject billDetail = new BillDetailObject()
                    {
                        BillID = countingbills,
                        PetID = pet.PetID,
                        QuantityBuy = pet.QuantityInStock, // Chỗ này UnitsInStock là số lượng mua của customer
                        Discount = Math.Round(float.Parse(txtDiscount.Text), 5),
                        SubTotal = (pet.QuantityInStock * pet.ExportPrice * (decimal)(1 - Math.Round(float.Parse(txtDiscount.Text), 5))),
                    };
                    billDetailRepository.InsertBillDetail(billDetail); // HƠI KÌ TRIGGER

                }

                bool check = false;
                //Sub quantity in stock 
                List<string> checkQuantityPet = petRepository.CheckQuantity(cart);
                if (checkQuantityPet.Count == 0)
                {
                    check = true;
                    petRepository.SubQuantityProduct(cart);
                    petRepository.SetStatusPet();
                }
                if (check)
                {
                    //CỘNG POINT CHO CUSTOMER
                    MessageBox.Show("Creating bill successfully!\n" +
                        "Thank you for being our loyal customer!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void txtPetID_TextChanged(object sender, EventArgs e)
        {
            if (txtPetID.Text.Trim().Length > 0)
            {
                try
                {
                    int petID = int.Parse(txtPetID.Text);
                    PetObject pet = petRepository.GetPetByPetID(petID);
                    if (pet.PetName.Length == 0)
                    {
                        ClearPetInfor();
                    }
                    else
                    {

                        txtPetName.Text = pet.PetName;
                        txtColor.Text = pet.Color;
                        txtPetAge.Text = pet.Age.ToString();
                        txtUnitPrice.Text = pet.ExportPrice.ToString();
                        txtQuantityInStock.Text = pet.QuantityInStock.ToString();
                        txtGender.Text = pet.Gender ? "Male" : "Female";
                    }
                }
                catch (Exception ex)
                {
                    ClearPetInfor();
                    MessageBox.Show("Sorry, we don't have this pet out store!" + ex.Message);
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length > 0)
            {
                CustomerObject cus = cusRepository.GetACustomerByEmail(txtEmail.Text.Trim());
                if (cus.CustomerID != 0)
                {
                    txtPhone.Text = cus.Phone;
                    txtPoint.Text = cus.AccumulatedPoint.ToString();
                    txtCusName.Text = cus.CustomerName;
                    txtAddress.Text = cus.Address;
                    cboCusGender.Text = cus.Gender ? "Male" : "Female";
                }
                else
                {
                    MessageBox.Show("Sorry, we can't find customer by this email hint!", "Message", MessageBoxButtons.OK);
                }
            }
            else
            {
                ClearCustomerInfo();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtColor.Text = string.Empty;
            txtCusName.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtFreight.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtGrandTotal.Text = string.Empty;
            txtPaidAmount.Text = string.Empty;
            txtPetAge.Text = string.Empty;
            txtPetID.Text = string.Empty;
            txtPetName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPoint.Text = string.Empty;
            txtQuantityBuy.Text = string.Empty;
            txtQuantityInStock.Text = string.Empty;
            txtReturnAmount.Text = string.Empty;
            txtSubTotal.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            dgvCart.Rows.Clear();
            dgvCart.Refresh();
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            cboCusGender.Enabled = true;
        }
    }
}
