using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class LoginService
    {
        LoginDao logindb;

        public LoginService()
        {
            logindb = new LoginDao();
        }

        public List<Login> GetAllLogins()
        {
            return logindb.GetLogins();
        }

        public Login GetUser(string username, string password)
        {
            Login login = logindb.GetUser(username, password);
            return login;
        }

        public Login GetUsername(string username)
        {
            Login login = logindb.GetUsername(username);
            return login;
        }

        public void AddUser(Login user)
        {
            logindb.AddNewAccount(user);
        }
    }
}
