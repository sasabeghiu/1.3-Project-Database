using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class Login : Form
    {
        LoginService loginService;
        public Login()
        {
            InitializeComponent();
            loginService = new LoginService();
        }
        
        //because of foreach, sometimes its showing the messagebox even if the credentials are correct
        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<SomerenModel.Login> lists = loginService.GetAllLogins();
            string username = txtUsername.Text;
            bool wrong = false; //wrong password

            foreach (var log in lists)//didnt know how else can do that so i used foreach
            {
                //Username: piet@infhaarlem.nl - Password: Welkom01
                //Username: rita@infhaarlem.nl - Password: Welkom02
                if ((log.Username == txtUsername.Text) && (log.Password == txtPassword.Text)) //checks the username and password in database
                {
                    this.Hide();

                    SomerenUI someren = new SomerenUI();
                    someren.ShowDialog();
                    this.Close();
                    break;//sometimes you log in but still see the messagebox
                }
                else
                {
                    wrong = true;
                }
                if (wrong == true)
                {
                    MessageBox.Show("Username or password incorrect! Please try again", "Login Error");
                    //break;  //was using this to show the messagebox only 1 time but then the 2nd user cant access the app
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }
    }
}
