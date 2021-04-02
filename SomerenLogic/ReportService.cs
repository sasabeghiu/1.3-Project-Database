using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class ReportService
    {
        ReportDao reportdb;

        public ReportService()
        {
            reportdb = new ReportDao();
        }
        //get a list with all reports
        public List<Report> GetAllReports()
        {
            return reportdb.GetAllReports();
        }
    }
}
