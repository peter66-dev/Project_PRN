using Business_Object;
using DataAccess.Repository;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinformPetStore
{
    public partial class frmPetss : Form
    {
        IPetRepository petRepository = new PetRepository();
        bool InsertOrUpdate;
        BindingSource source;

        public frmPetss()
        {
            InitializeComponent();
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

        void LoadListView()
        {
            var pets = petRepository.GetPetList();
            try
            {
                source = new BindingSource();
                source.DataSource = pets;
                txtPetID.DataBindings.Clear();
                txtPetName.DataBindings.Clear();
                txtAge.DataBindings.Clear();
                txtColor.DataBindings.Clear();
                txtGender.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtImportPrice.DataBindings.Clear();
                txtExportPrice.DataBindings.Clear();
                txtQuantityInStock.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtPetID.DataBindings.Add("Text", source, "PetID");
                txtPetName.DataBindings.Add("Text", source, "PetName");
                txtAge.DataBindings.Add("Text", source, "Age");
                txtColor.DataBindings.Add("Text", source, "Color");
                txtGender.DataBindings.Add("Text", source, "Gender");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
                txtImportPrice.DataBindings.Add("Text", source, "ImportPrice");
                txtExportPrice.DataBindings.Add("Text", source, "ExportPrice");
                txtQuantityInStock.DataBindings.Add("Text", source, "QuantityInStock");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dgvPetList.DataSource = null;
                dgvPetList.DataSource = source;

                dgvPetList.Columns["PetID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["PetName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Age"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Gender"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["ImportPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["ExportPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["QuantityInStock"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvPetList.Columns["PetID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["PetName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvPetList.Columns["Age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["ImportPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPetList.Columns["ExportPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPetList.Columns["QuantityInStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPetList.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (pets.Count() == 0)
                {
                    Reset();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load pet list");
            }
        }

        private PetObject GetPet()
        {
            PetObject pet = null;
            try
            {
                pet = new PetObject(int.Parse(txtPetID.Text),
                txtPetName.Text, int.Parse(txtAge.Text), bool.Parse(txtGender.Text),
                txtColor.Text, int.Parse(txtQuantityInStock.Text), int.Parse(txtCategoryID.Text),
                decimal.Parse(txtImportPrice.Text), decimal.Parse(txtExportPrice.Text), bool.Parse(txtStatus.Text));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Get pet");
            }
            return pet;
        }

        private void frmPets_Load(object sender, EventArgs e)
        {
            LoadListView();
            dgvPetList.CellDoubleClick += DgvPetList_CellDoubleClick;
        }

        private void DgvPetList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            txtPetName.Enabled = true;
            txtAge.Enabled = true;
            txtColor.Enabled = true;
            txtGender.Enabled = true;
            txtCategoryID.Enabled = true;
            txtImportPrice.Enabled = true;
            txtExportPrice.Enabled = true;
            txtQuantityInStock.Enabled = true;
            txtStatus.Enabled = true;
            InsertOrUpdate = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            if (btnAdd.Text.Equals("ADD"))
            {
                for (int i = 0; i < dgvPetList.SelectedRows.Count; i++)
                {
                    dgvPetList.SelectedRows[i].Selected = false;
                }
                btnAdd.Text = "CANCEL";
                btnSave.Enabled = true;
                txtPetName.Enabled = true;
                txtAge.Enabled = true;
                txtColor.Enabled = true;
                txtGender.Enabled = true;
                txtCategoryID.Enabled = true;
                txtImportPrice.Enabled = true;
                txtExportPrice.Enabled = true;
                txtQuantityInStock.Enabled = true;
                txtStatus.Enabled = true;
                txtPetID.Focus();
                InsertOrUpdate = false;
            }
            else
            {
                btnAdd.Text = "ADD";
                btnSave.Enabled = false;
                txtPetName.Enabled = false;
                txtAge.Enabled = false;
                txtColor.Enabled = false;
                txtGender.Enabled = false;
                txtCategoryID.Enabled = false;
                txtImportPrice.Enabled = false;
                txtExportPrice.Enabled = false;
                txtQuantityInStock.Enabled = false;
                txtStatus.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var pet = GetPet();
            if (InsertOrUpdate == false)
            {
                petRepository.InsertPet(pet);
                btnAdd.Text = "ADD";
            }
            else
            {
                petRepository.UpdatePet(pet);
            }
            btnSave.Enabled = false;
            txtPetName.Enabled = false;
            txtAge.Enabled = false;
            txtColor.Enabled = false;
            txtGender.Enabled = false;
            txtCategoryID.Enabled = false;
            txtImportPrice.Enabled = false;
            txtExportPrice.Enabled = false;
            txtQuantityInStock.Enabled = false;
            txtStatus.Enabled = false;
            LoadListView();
            source.Position = source.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure to delete?", "Pet Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var pet = GetPet();
                petRepository.RemovePet(pet.PetID);
            }
            LoadListView();
        }
    }
}
