using Business_Object;
using DataAccess.Repository;
using GroupAssignment;
using System;
using System.Windows.Forms;

namespace WinformPetStore
{
    public partial class frmCustomerDetails : Form
    {
        public ICustomerRepository customerRepository { get; set; }
        public bool InsertOrUpdate;
        public CustomerObject CustomerInfo { get; set; }

        public frmCustomerDetails()
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
        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            try
            {
                cboGender.SelectedIndex = 0;
                if (InsertOrUpdate) // update
                {
                    txtCusID.Text = CustomerInfo.CustomerID.ToString();
                    txtCusName.Text = CustomerInfo.CustomerName;
                    txtEmail.Text = CustomerInfo.Email;
                    txtPhone.Text = CustomerInfo.Phone;
                    cboGender.Text = CustomerInfo.Gender ? "Male" : "Female";
                    txtAddress.Text = CustomerInfo.Address;
                    txtPoint.Text = CustomerInfo.AccumulatedPoint.ToString();
                    cboStatus.Text = CustomerInfo.Status ? "Actived" : "Inactived";
                }
                else // insert
                {
                    txtCusID.Text = "xxx";
                    cboStatus.Text = "Actived";
                    cboStatus.Enabled = false;
                }
                cboGender.Focus();
            }
            catch (Exception ex)
            {
            }
        }
        private bool CheckForm()
        {
            bool check = true;
            try
            {
                if (txtCusName.Text.Trim().Length == 0)
                {
                    txtCusName.Focus();
                    MessageBox.Show("Sorry, you must full fill in customer name field please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (!(txtEmail.Text.Contains("@gmail.com") || txtEmail.Text.Contains("@fpt.edu.vn")))
                {
                    txtEmail.Focus();
                    MessageBox.Show("Sorry, email must be xxx@gmail.com or xxx@fpt.edu.vn.\n" +
                        "Please, try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (!(cboGender.Text.Equals("female", StringComparison.OrdinalIgnoreCase) ||
                    cboGender.Text.Equals("male", StringComparison.OrdinalIgnoreCase)))
                {
                    cboGender.Focus();
                    MessageBox.Show("Sorry, gender must be Male or Female please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (!(txtPhone.Text.Trim().Length >= 10 && txtPhone.Text.Trim().Length <= 12 && decimal.Parse(txtPhone.Text) > 0))
                {
                    txtPhone.Focus();
                    MessageBox.Show("Sorry, phone must have [10-12] numbers please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (txtAddress.Text.Trim().Length < 10)
                {
                    txtAddress.Focus();
                    MessageBox.Show("Sorry, address is not enough information. Give me more, please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (Decimal.ToInt32(txtPoint.Value) < 0)
                {
                    txtPoint.Focus();
                    MessageBox.Show("Sorry, accumulated point must be more 0 please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (!(cboStatus.Text.Equals("actived", StringComparison.OrdinalIgnoreCase) ||
                    cboStatus.Text.Equals("inactived", StringComparison.OrdinalIgnoreCase)))
                {
                    txtPoint.Focus();
                    MessageBox.Show("Sorry, status must be Actived or Inactived please!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, data input is not valid. Check again, please! " + ex.Message,
                    "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return check;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckForm())
                {
                    string email = txtEmail.Text.Trim();
                    string phone = txtPhone.Text.Trim();
                    if (InsertOrUpdate) // update
                    {
                        if (customerRepository.CheckCustomerByIDandEmailAndPhone(int.Parse(txtCusID.Text), email, phone)) // existed in system!
                        {
                            MessageBox.Show("Sorry, this email or phone number has existed in system!\n" +
                                "Please update another email or phone number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEmail.Focus();
                        }
                        else
                        {
                            CustomerObject cus = new CustomerObject();
                            cus.CustomerID = int.Parse(txtCusID.Text);
                            cus.CustomerName = txtCusName.Text.Trim();
                            cus.Gender = cboGender.Text.Equals("male", StringComparison.OrdinalIgnoreCase) ? true : false;
                            cus.Phone = phone;
                            cus.Email = email;
                            cus.Address = txtAddress.Text.Trim();
                            cus.AccumulatedPoint = Decimal.ToInt32(txtPoint.Value);
                            cus.Status = cboStatus.Text.Trim().Equals("actived", StringComparison.OrdinalIgnoreCase);
                            customerRepository.UpdateCustomer(cus);
                            MessageBox.Show("Updating a customer successfully!\n" +
                                "Load again to see new list!", "Message", MessageBoxButtons.OK);
                            Close();
                        }
                    }
                    else // insert
                    {
                        if (customerRepository.CheckCustomerByEmailAndPhone(email, phone)) // existed in system!
                        {
                            MessageBox.Show("Sorry, this email and phone has existed in system!\n" +
                                "Please update status for this customer instead of creating a new account",
                                "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEmail.Focus();
                        }
                        else
                        {
                            CustomerObject cus = new CustomerObject();
                            cus.CustomerID = 0;
                            cus.CustomerName = txtCusName.Text.Trim();
                            cus.Gender = cboGender.Text.Equals("male", StringComparison.OrdinalIgnoreCase) ? true : false;
                            cus.Phone = phone;
                            cus.Email = email;
                            cus.Address = txtAddress.Text.Trim();
                            cus.AccumulatedPoint = Decimal.ToInt32(txtPoint.Value);
                            cus.Status = true;
                            customerRepository.InsertCustomer(cus);
                            MessageBox.Show("Adding a new customer successfully!\n" +
                                "Load again to see new list!", "Message", MessageBoxButtons.OK);
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding a new customer failed! Check all information again, please! " + ex.Message,
                    "Customer information", MessageBoxButtons.OK);
            }

        }

        private void frmCustomerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "Message", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
