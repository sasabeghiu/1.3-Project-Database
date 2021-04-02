using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class LoginDao : BaseDao
    {
        //getting all users from database (login was a bad name)
        public List<Login> GetLogins()
        {
            string query = "SELECT Username, Password FROM Login";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Login> ReadTables(DataTable dataTable)
        {
            List<Login> logins = new List<Login>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Login login = new Login()
                {
                    Username = (string)dr["Username"],
                    Password = (string)(dr["Password"]),
                };
                logins.Add(login);
            }
            return logins;
        }

        //adding a new user
        public void AddNewAccount(Login user)
        {
            string query = $"INSERT INTO [Login] (Username, Password) Values ('{user.Username}','{user.Password}') ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
