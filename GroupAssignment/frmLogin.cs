using System;
using System.Windows.Forms;
using GroupAssignment;
using Microsoft.Extensions.Configuration;

namespace WinformPetStore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool isLogin { private set; get; }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }

        bool CheckForm()
        {
            bool check = true;
            if (txtEmail.Text.Trim().Length == 0)
            {
                txtEmail.Focus();
                check = false;
                MessageBox.Show("Email is not allowed to be empty. Please try again!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text.Trim().Length == 0)
            {
                txtPassword.Focus();
                check = false;
                MessageBox.Show("Password is not allowed to be empty. Please try again!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return check;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                var admin = Program.Configuration.GetSection("AdminAccount").Get<DefaultAccountSettings>();
                string adminEmail = admin.username;
                string adminPassword = admin.password;

                if (adminEmail.Equals(email) && adminPassword.Equals(password))
                {
                    isLogin = true;
                    Close();
                }
                else
                {
                    txtEmail.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                    MessageBox.Show("Wrong username and password. Please try again!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }

    public class DefaultAccountSettings
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
