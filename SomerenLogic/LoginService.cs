using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class LoginService
    {
        LoginDao logindb;

        public LoginService()
        {
            logindb = new LoginDao();
        }
        //get all users
        public List<Login> GetAllLogins()
        {
            return logindb.GetLogins();
        }
        //add user
        public void AddUser(Login user)
        {
            logindb.AddNewAccount(user);
        }
    }
}
