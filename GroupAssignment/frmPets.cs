using Business_Object;
using DataAccess.Repository;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using DataAccess;
using GroupAssignment;

namespace WinformPetStore
{
    public partial class frmPetss : Form
    {
        IPetRepository petRepository = new PetRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        BindingSource source = new BindingSource();
        List<PetObject> pets = new List<PetObject>();
        PetObject currentPet = new PetObject();

        public frmPetss()
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

        private void frmPets_Load(object sender, EventArgs e)
        {
            pets = petRepository.GetPetList();
            LoadPetList(pets);
            LoadCategoryList();
        }

        void Reset()
        {
            txtPetID.Text = "";
            txtPetName.Text = "";
            txtAge.Text = "";
            txtColor.Text = "";
            txtGender.Text = "";
            txtCategoryID.Text = "";
            txtImportPrice.Text = "";
            txtExportPrice.Text = "";
            txtQuantityInStock.Text = "";
            txtStatus.Text = "";
        }

        private void LoadCategoryList()
        {
            var categories = categoryRepository.GetCategoryList();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
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

        private void LoadPetList(IEnumerable<PetObject> list)
        {
            try
            {
                if (list.Count() == 0)
                {
                    Reset();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    MessageBox.Show("Sorry, we can't show result you want!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (list.Count() == 1)
                {
                    btnDelete.Enabled = false;
                    dgvPetList.Rows.Clear();
                    PetObject pet = list.ElementAt(0);
                    string gender = pet.Gender ? "Male" : " Female";
                    string status = pet.Status ? "Actived" : "Inactived";
                    string category = CategoryPet(pet.CategoryID);
                    dgvPetList.Rows.Add(pet.PetID, category, pet.PetName, pet.Age, gender, pet.Color,
                        pet.QuantityInStock, pet.ImportPrice, pet.ExportPrice, status);
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    dgvPetList.Rows.Clear();
                    foreach (var pet in list)
                    {
                        string gender = pet.Gender ? "Male" : " Female";
                        string category = CategoryPet(pet.CategoryID);
                        string status = pet.Status ? "Actived" : "Inactived";
                        dgvPetList.Rows.Add(pet.PetID, category, pet.PetName, pet.Age, gender, pet.Color,
                        pet.QuantityInStock, pet.ImportPrice, pet.ExportPrice, status);
                    }
                }
                source.DataSource = list;
                Reset();

                txtPetID.DataBindings.Add("Text", source, "PetID");
                txtPetName.DataBindings.Add("Text", source, "PetName");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
                txtGender.DataBindings.Add("Text", source, "Gender");
                txtColor.DataBindings.Add("Text", source, "Color");
                txtImportPrice.DataBindings.Add("Text", source, "ImportPrice");
                txtExportPrice.DataBindings.Add("Text", source, "ExportPrice");
                txtAge.DataBindings.Add("Text", source, "Age");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtQuantityInStock.DataBindings.Add("Text", source, "QuantityInStock");

                dgvPetList.Columns["PetID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["PetName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Gender"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["ImportPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["ExportPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Age"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Quantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvPetList.Columns["PetID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["PetName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvPetList.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvPetList.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["ImportPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPetList.Columns["ExportPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPetList.Columns["Age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvPetList.Columns["PetID"].ReadOnly = true;
                dgvPetList.Columns["PetName"].ReadOnly = true;
                dgvPetList.Columns["CategoryID"].ReadOnly = true;
                dgvPetList.Columns["Gender"].ReadOnly = true;
                dgvPetList.Columns["Color"].ReadOnly = true;
                dgvPetList.Columns["ImportPrice"].ReadOnly = true;
                dgvPetList.Columns["ExportPrice"].ReadOnly = true;
                dgvPetList.Columns["Age"].ReadOnly = true;
                dgvPetList.Columns["Status"].ReadOnly = true;
                dgvPetList.Columns["Quantity"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Load member list", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmPetDetails()
                {
                    Text = "Add a new pet",
                    InsertOrUpdate = false,
                    petRepository = petRepository
                };
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    pets = petRepository.GetPetList();
                    LoadPetList(pets);
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
                PetObject pet = currentPet;
                if (pet.PetID != 0)
                {
                    var frm = new frmPetDetails()
                    {
                        Text = "Update a pet",
                        InsertOrUpdate = true,
                        petRepository = petRepository,
                        PetInfo = currentPet
                    };
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        pets = petRepository.GetPetList();
                        LoadPetList(pets);
                    }
                }
                else
                {
                    MessageBox.Show($"Sorry, choose pet you want to update please!", "Update customer message", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var pet = currentPet;
                if (MessageBox.Show($"Are you sure to delete pet {pet.PetName}?", "Delete confirmation!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    petRepository.RemovePet(pet.PetID);
                    MessageBox.Show("Removing successfully!", "Message!", MessageBoxButtons.OK);
                    Reset();
                    LoadPetList(petRepository.GetPetList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete! Error: " + ex.Message, "Error message!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPetList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var dgvRow = dgvPetList.Rows[e.RowIndex];
                    txtPetID.Text = dgvRow.Cells[0].Value.ToString();
                    txtCategoryID.Text = dgvRow.Cells[1].Value.ToString();
                    txtPetName.Text = dgvRow.Cells[2].Value.ToString();
                    txtAge.Text = dgvRow.Cells[3].Value.ToString();
                    txtGender.Text = dgvRow.Cells[4].Value.ToString();
                    txtColor.Text = dgvRow.Cells[5].Value.ToString();
                    txtQuantityInStock.Text = dgvRow.Cells[6].Value.ToString();
                    txtImportPrice.Text = dgvRow.Cells[7].Value.ToString();
                    txtExportPrice.Text = dgvRow.Cells[8].Value.ToString();
                    txtStatus.Text = dgvRow.Cells[9].Value.ToString();

                    currentPet.PetID = int.Parse(dgvRow.Cells[0].Value.ToString());
                    string category = dgvRow.Cells[1].Value.ToString();
                    currentPet.CategoryID = CategoryPet(category);
                    currentPet.PetName = dgvRow.Cells[2].Value.ToString();
                    currentPet.Age = int.Parse(dgvRow.Cells[3].Value.ToString());
                    currentPet.Gender = dgvRow.Cells[4].Value.ToString().Equals("Male", StringComparison.OrdinalIgnoreCase);
                    currentPet.Color = dgvRow.Cells[5].Value.ToString();
                    currentPet.QuantityInStock = int.Parse(dgvRow.Cells[6].Value.ToString());
                    currentPet.ImportPrice = decimal.Parse(dgvRow.Cells[7].Value.ToString());
                    currentPet.ExportPrice = decimal.Parse(dgvRow.Cells[8].Value.ToString());
                    currentPet.Status = dgvRow.Cells[9].Value.ToString().Equals("Actived", StringComparison.OrdinalIgnoreCase);


                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbCategory.SelectedValue.ToString() != null)
                {
                    int categoryID = int.Parse(cbCategory.SelectedValue.ToString());
                    string catename = cbCategory.Text.Trim();
                    int cateID = CategoryPet(catename);
                    if (cateID >= 1 && cateID <= 5)
                    {
                        txtSearch.Text = "";
                        var pets = petRepository.GetPetList();
                        var list = new List<PetObject>();
                        foreach (var pet in pets)
                        {
                            if (pet.CategoryID == categoryID)
                            {
                                list.Add(pet);
                            }
                        }
                        LoadPetList(list);
                    }
                    else
                    {
                        MessageBox.Show("Sorry, we just have Dog, Cat, Rabbit, Hamster, Hedgehog!", "Category message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    throw new Exception("Exception happend");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length != 0)
            {
                try
                {
                    pets = petRepository.GetPetByPetName(txtSearch.Text.Trim());
                    if (pets.Count != 0)
                    {
                        LoadPetList(pets);
                    }
                    //else
                    //{
                    //    MessageBox.Show("Sorry, we can't find this pet!",
                    //    "Search message", MessageBoxButtons.OK);
                    //    LoadPetList(pets);
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                        "txtSearch_TextChanged", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            pets = petRepository.GetPetList();
            LoadPetList(pets);
        }
    }
}
