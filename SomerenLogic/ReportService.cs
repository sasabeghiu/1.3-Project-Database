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
    public class ReportService
    {
        ReportDao reportdb;

        public ReportService()
        {
            reportdb = new ReportDao();
        }
        public List<Report> GetAllReports()
        {
            return reportdb.GetAllReports();
        }
    }
}
