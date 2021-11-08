using Business_Object;
using DataAccess.Repository;
using GroupAssignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformPetStore
{
    public partial class frmPetDetails : Form
    {
        public IPetRepository petRepository { get; set; }
        public bool InsertOrUpdate;
        public PetObject PetInfo { get; set; }

        public frmPetDetails()
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

        string CategoryPet(int id)
        {
            string s = "";
            switch (id)
            {
                case 1:
                    {
                        s = "Dog";
                        break;
                    }
                case 2:
                    {
                        s = "Cat";
                        break;
                    }
                case 3:
                    {
                        s = "Rabbit";
                        break;
                    }
                case 4:
                    {
                        s = "Hamster";
                        break;
                    }
                case 5:
                    {
                        s = "Hedgehog";
                        break;
                    }

                default:
                    {
                        s = "Animal";
                        break;
                    }
            }
            return s;
        }

        int CategoryPet(string cate)
        {
            int id = 0;
            switch (cate)
            {
                case "Dog":
                    {
                        id = 1;
                        break;
                    }
                case "dog":
                    {
                        id = 1;
                        break;
                    }
                case "Cat":
                    {
                        id = 2;
                        break;
                    }
                case "cat":
                    {
                        id = 2;
                        break;
                    }
                case "Rabbit":
                    {
                        id = 3;
                        break;
                    }
                case "rabbit":
                    {
                        id = 3;
                        break;
                    }
                case "Hamster":
                    {
                        id = 4;
                        break;
                    }
                case "hamster":
                    {
                        id = 4;
                        break;
                    }
                case "Hedgehog":
                    {
                        id = 5;
                        break;
                    }
                case "hedgehog":
                    {
                        id = 5;
                        break;
                    }
            }
            return id;
        }

        private void frmPetDetails_Load(object sender, EventArgs e)
        {
            try
            {
                cboGender.SelectedIndex = 0;
                cboCate.SelectedIndex = 0;
                if (InsertOrUpdate) // update
                {
                    txtPetID.Text = PetInfo.PetID.ToString();
                    txtPetName.Text = PetInfo.PetName.ToString();
                    cboCate.Text = CategoryPet(PetInfo.CategoryID);
                    txtAge.Text = PetInfo.Age.ToString();
                    cboGender.Text = PetInfo.Gender ? "Male" : "Female";
                    txtColor.Text = PetInfo.Color;
                    txtQuantity.Text = PetInfo.QuantityInStock.ToString();
                    txtImport.Text = PetInfo.ImportPrice.ToString();
                    txtExport.Text = PetInfo.ExportPrice.ToString();
                }
                else
                {
                    txtPetID.Text = "xxx";
                }
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
                if (txtPetName.Text.Trim().Length == 0)
                {
                    txtPetName.Focus();
                    MessageBox.Show("Sorry, you must full fill in pet name field please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (cboCate.Text.Trim().Equals("dog") ||
                   cboCate.Text.Trim().Equals("cat") ||
                   cboCate.Text.Trim().Equals("rabbit") ||
                   cboCate.Text.Trim().Equals("hamster") ||
                   cboCate.Text.Trim().Equals("dog") ||
                   cboCate.Text.Trim().Equals("hedgehog"))
                {
                    cboCate.Focus();
                    MessageBox.Show($"Sorry, we don't have Category name: {cboCate.Text}!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (txtAge.Value <= 0)
                {
                    txtAge.Focus();
                    MessageBox.Show("Sorry, Pet Age must be more than 0\n" +
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
                else if (txtColor.Text.Trim().Length == 0)
                {
                    txtColor.Focus();
                    MessageBox.Show("Sorry, you must full fill in color pet field please!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }

                else if (!(decimal.TryParse(txtImport.Text, out decimal value) && value >= 10000))
                {
                    txtImport.Focus();
                    MessageBox.Show("Sorry, import price is so cheap!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if ((txtQuantity.Value < 0))
                {
                    txtQuantity.Focus();
                    MessageBox.Show("Sorry, Quantity must be >= 0!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (int.Parse(txtExport.Text) < 100000)
                {
                    txtExport.Focus();
                    MessageBox.Show("Sorry, export price is so cheap!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = false;
                }
                else if (int.Parse(txtImport.Text) > int.Parse(txtExport.Text))
                {
                    txtExport.Focus();
                    MessageBox.Show("Sorry, import price must be less than export price!",
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckForm())
                {
                    if (InsertOrUpdate) // update
                    {
                        PetObject pet = new PetObject();
                        pet.PetID = PetInfo.PetID;
                        pet.PetName = txtPetName.Text.Trim();
                        pet.Gender = cboGender.Text.Equals("male", StringComparison.OrdinalIgnoreCase) ? true : false;
                        pet.Age = int.Parse(txtAge.Text);
                        pet.Color = txtColor.Text.Trim();
                        pet.ImportPrice = decimal.Parse(txtImport.Text);
                        pet.ExportPrice = decimal.Parse(txtExport.Text);
                        pet.QuantityInStock = Decimal.ToInt32(txtQuantity.Value);
                        pet.CategoryID = CategoryPet(cboCate.Text);
                        pet.Status = true;
                        petRepository.UpdatePet(pet);
                        MessageBox.Show("Updating a pet successfully!\n" +
                            "Load again to see new list!", "Message", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        PetObject pet = new PetObject();
                        pet.PetID = 0;
                        pet.PetName = txtPetName.Text.Trim();
                        pet.Gender = cboGender.Text.Equals("male", StringComparison.OrdinalIgnoreCase) ? true : false;
                        pet.Gender = cboGender.Text.Equals("male", StringComparison.OrdinalIgnoreCase) ? true : false;
                        pet.Age = int.Parse(txtAge.Text);
                        pet.Color = txtColor.Text.Trim();
                        pet.ImportPrice = decimal.Parse(txtImport.Text);
                        pet.ExportPrice = decimal.Parse(txtExport.Text);
                        pet.QuantityInStock = Decimal.ToInt32(txtQuantity.Value);
                        pet.CategoryID = CategoryPet(cboCate.Text);
                        pet.Status = true;
                        petRepository.InsertPet(pet);
                        MessageBox.Show("Adding a new pettomer successfully!\n" +
                            "Load again to see new list!", "Message", MessageBoxButtons.OK);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding a new pettomer failed! Check all information again, please! " + ex.Message,
                    "Customer information", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmPetDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "Message", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
