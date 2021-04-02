using SomerenLogic;
using SomerenModel;
using System;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //register a new user 
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //the key for registering
            string key = "XsZAb - tgz3PsD - qYh69un - WQCEx"; 
            SomerenModel.Login newUser = new SomerenModel.Login();
            newUser.Username = txtUsername.Text;
            newUser.Password = txtPassword.Text;

            if (txtLicenseKey.Text == key)
            {
                LoginService registerService = new LoginService();
                registerService.AddUser(newUser);
                MessageBox.Show("Congratulations with your new account!\nPlease log in with your credentials!", "Welcome to Someren!");
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
