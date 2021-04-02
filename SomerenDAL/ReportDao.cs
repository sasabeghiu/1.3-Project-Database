using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class ReportDao : BaseDao
    {
        //returning a list of reports
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
