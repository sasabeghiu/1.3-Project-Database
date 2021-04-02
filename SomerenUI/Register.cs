using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string key = "XsZAb - tgz3PsD - qYh69un - WQCEx";

            SomerenModel.Login newUser = new SomerenModel.Login();
            newUser.Username = txtUsername.Text;
            newUser.Password = txtPassword.Text;
            if (txtLicenseKey.Text == key)
            {
                LoginService registerService = new LoginService();
                registerService.AddUser(newUser);
                MessageBox.Show("Congratulations with your new account!\nPlease log in with your credentials!");
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid license key!");
            }
        }
    }
}
