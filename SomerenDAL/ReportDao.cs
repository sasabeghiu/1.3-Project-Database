using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class ReportDao : BaseDao
    {
        public List<Report> GetAllReports()
        {
            string query = "SELECT COUNT(DrinkId) AS NrDrinks, COUNT(DISTINCT StudentId) AS NrStudents, DrinkPrice FROM [StudentDrink] GROUP BY DrinkPrice";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Report> ReadTables(DataTable dataTable)
        {
            List<Report> reports = new List<Report>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Report report = new Report()
                {
                    Sales = (int)dr["NrDrinks"],
                    Turnover = (int)(dr["DrinkPrice"]),  
                    Customers = (int)(dr["NrStudents"])
                };
                reports.Add(report);
            }
            return reports;
        }
    }
}
