using Buisness.Managers;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSolutionUI
{
    public partial class FrmLogin : Form
    {
        UserManager _userManager;
        public FrmLogin()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = _userManager.ValidateUser(username, password);

            if (user != null)
            {
                FrmMain mainForm = new FrmMain();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Geçersiz kullanıcı adı veya şifre!";
                lblMessage.Visible = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
