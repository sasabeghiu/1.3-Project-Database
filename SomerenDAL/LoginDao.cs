using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using System.Configuration;

namespace SomerenDAL
{
    public class LoginDao : BaseDao
    {
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

        public Login GetUser(string username, string password)
        {
            string query = $"SELECT Username, Password FROM [Login] WHERE Username = '{username}' AND Password = '{password}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Login> users = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (users.Count == 0)
            {
                return null;
            }
            else
            {
                return users[0];
            }
        }

        public Login GetUsername(string username)
        {
            string query = $"SELECT Username, Password FROM [Login] WHERE Username = '{username}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Login> users = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (users.Count == 0)
            {
                return null;
            }
            else
            {
                return users[0];
            }
        }

        public void AddNewAccount(Login user)
        {
            string query = $"INSERT INTO [Login] (Username, Password) Values ('{user.Username}','{user.Password}') ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
