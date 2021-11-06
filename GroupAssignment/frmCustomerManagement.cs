using System;
using Business_Object;
using DataAccess.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GroupAssignment;

namespace WinformPetStore
{
    public partial class frmCustomerManagement : Form
    {
        ICustomerRepository cusRepository = new CustomerRepository();
        BindingSource source = new BindingSource();
        IEnumerable<CustomerObject> customers = new List<CustomerObject>();
        bool asc = true;
        public frmCustomerManagement()
        {
            if (Program.isLogin)
            {
                InitializeComponent();
                btnLoad.Focus();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSort.Enabled = false;
            }
            else
            {
                Application.Restart();
            }
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            btnLoad.Focus();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSort.Enabled = false;
        }
        private void ClearText()
        {
            txtCusID.Clear();
            txtCusName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cboGender.Text = string.Empty;
            txtPhone.Clear();
            txtStatus.Clear();
            txtPoint.Clear();
        }
        private void LoadCustomerList(IEnumerable<CustomerObject> list)
        {
            try
            {
                if (list.Count() == 0)
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSort.Enabled = false;
                    MessageBox.Show("Sorry, we can't show result you want!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (list.Count() == 1)
                {
                    btnDelete.Enabled = false;
                    btnSort.Enabled = false;
                    dgvCustomerList.Rows.Clear();
                    CustomerObject cus = list.ElementAt(0);
                    string gender = cus.Gender ? "Male" : " Female";
                    string status = cus.Status ? "Actived" : "Deactived";
                    dgvCustomerList.Rows.Add(cus.CustomerID, cus.CustomerName, gender, cus.Email, cus.Phone, cus.Address, cus.AccumulatedPoint, status);
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnSort.Enabled = true;
                    dgvCustomerList.Rows.Clear();
                    foreach (var cus in list)
                    {
                        string gender = cus.Gender ? "Male" : " Female";
                        string status = cus.Status ? "Actived" : "Deactived";
                        dgvCustomerList.Rows.Add(cus.CustomerID, cus.CustomerName, gender, cus.Email, cus.Phone, cus.Address, cus.AccumulatedPoint, status);
                    }
                }
                source.DataSource = list;
                ClearText();

                txtCusID.DataBindings.Add("Text", source, "CustomerID");
                txtCusName.DataBindings.Add("Text", source, "CustomerName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtPoint.DataBindings.Add("Text", source, "AccumulatedPoint");
                cboGender.DataBindings.Add("Text", source, "Gender");

                dgvCustomerList.Columns["CustomerID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["CustomerName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCustomerList.Columns["Address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvCustomerList.Columns["Phone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvCustomerList.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["AccumulatedPoint"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dgvCustomerList.Columns["CustomerID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["CustomerName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Address"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Phone"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["AccumulatedPoint"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCustomerList.Columns["Gender"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvCustomerList.Columns["CustomerID"].ReadOnly = true;
                dgvCustomerList.Columns["CustomerName"].ReadOnly = true;
                dgvCustomerList.Columns["Email"].ReadOnly = true;
                dgvCustomerList.Columns["Address"].ReadOnly = true;
                dgvCustomerList.Columns["Phone"].ReadOnly = true;
                dgvCustomerList.Columns["Status"].ReadOnly = true;
                dgvCustomerList.Columns["AccumulatedPoint"].ReadOnly = true;
                dgvCustomerList.Columns["Gender"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Load member list", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private CustomerObject GetCustomerObject()
        {
            CustomerObject cus = new CustomerObject();
            try
            {
                cus.CustomerID = int.Parse(txtCusID.Text);
                cus.CustomerName = txtCusName.Text;
                cus.Email = txtEmail.Text;
                cus.Phone = txtPhone.Text;
                cus.Address = txtAddress.Text;
                cus.Status = txtStatus.Equals("Actived") ? true : false;
                cus.Gender = cboGender.Text.Equals("male",StringComparison.OrdinalIgnoreCase) ? true : false;
                cus.AccumulatedPoint = int.Parse(txtPoint.Text);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Get customer object", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return cus;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtEmailSearch.Clear();
            customers = cusRepository.GetCustomerList();
            LoadCustomerList(customers);
            btnSort.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmCustomerDetails()
                {
                    Text = "Add a new customer",
                    InsertOrUpdate = false,
                    customerRepository = cusRepository
                };
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customers = cusRepository.GetCustomerList();
                    LoadCustomerList(customers);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerObject cus = GetCustomerObject();
                if (cus.CustomerID != 0)
                {
                    var frm = new frmCustomerDetails()
                    {
                        Text = "Update a customer",
                        InsertOrUpdate = true,
                        CustomerInfo = GetCustomerObject(),
                        customerRepository = cusRepository
                    };
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        customers = cusRepository.GetCustomerList();
                        LoadCustomerList(customers);
                    }
                }
                else
                {
                    MessageBox.Show($"Sorry, choose customer you want to update please!", "Update customer message", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var cus = GetCustomerObject();
                if (MessageBox.Show($"Are you sure to delete member name: {cus.Email}?", "Confirm message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (cusRepository.GetCustomerForeignKey(cus.CustomerID).CustomerID == 0) // Không bị ảnh hưởng khóa ngoại với bảng Order
                    {
                        try
                        {
                            source.Position = 0;
                            cusRepository.DeleteCustomer(cus.CustomerID);
                            customers = cusRepository.GetCustomerList();
                            LoadCustomerList(customers);
                            if (cusRepository.GetCustomerList().Count() == 1)
                            {
                                btnDelete.Enabled = false;
                                MessageBox.Show("We have only 1 customer existing in list, now. Please don't remove it!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Delete a customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can delete this Customer because it's foreign key of Order table in sql server!",
                                            "Delete a customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // KHÔNG CHO DELETE VÌ CUSTOMER ĐANG LÀM KHÓA NGOẠI BÊN ORDER
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            txtEmailSearch.Clear();
            if (asc)
            {
                LoadCustomerList(cusRepository.SortCustomerAscendingName());
            }
            else
            {
                LoadCustomerList(cusRepository.SortCustomerDescendingName());
            }
            asc = !asc;
        }
        private void txtEmailSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtEmailSearch.Text.Trim().Length != 0)
            {
                List<CustomerObject> list = cusRepository.GetCustomerByEmail(txtEmailSearch.Text.Trim());
                if (list.Count == 0)
                {
                    MessageBox.Show("Sorry, we can't find this customer is system!\nPlease, try again", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    LoadCustomerList(list);
                }
            }
        }
        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var dgvRow = dgvCustomerList.Rows[e.RowIndex];
                    txtCusID.Text = dgvRow.Cells[0].Value.ToString();
                    txtCusName.Text = dgvRow.Cells[1].Value.ToString();
                    cboGender.Text = dgvRow.Cells[2].Value.ToString();
                    txtEmail.Text = dgvRow.Cells[3].Value.ToString();
                    txtPhone.Text = dgvRow.Cells[4].Value.ToString();
                    txtAddress.Text = dgvRow.Cells[5].Value.ToString();
                    txtPoint.Text = dgvRow.Cells[6].Value.ToString();
                    txtStatus.Text = dgvRow.Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
