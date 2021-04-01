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
        //login button
        //edit the form + find a way not to use foreach
        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<SomerenModel.Login> lists = loginService.GetAllLogins();
            foreach (var log in lists)//didnt know how else can do that so i used foreach
            {
                //Username: piet@infhaarlem.nl - Password: Welkom01
                //Username: rita@infhaarlem.nl - Password: Welkom02
                if (log.Username == txtUsername.Text && log.Password == txtPassword.Text) //checks the username and password in database
                {
                    SomerenUI someren = new SomerenUI();
                    this.Hide();
                    someren.Show();
                    break;//sometimes you log in but still see the messagebox
                }
                else
                {
                    MessageBox.Show("Username or password incorrect! Please try again", "Login Error");
                    //break;  //was using this to show the messagebox only 1 time but then the 2nd user cant access the app
                }
                
            }
        }
    }
}
