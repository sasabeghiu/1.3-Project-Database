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
    }
}
