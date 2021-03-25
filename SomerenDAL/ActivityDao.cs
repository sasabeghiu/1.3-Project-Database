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
    public class ActivityDao : BaseDao
    {
        //returns a list of activities from database
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT ActivityID, Description, StartDateTime, EndDateTime FROM [Activity]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ID = (int)dr["ActivityID"],
                    Description = (string)(dr["Description"]),
                    StartTime = (DateTime)(dr["StartDateTime"]),
                    EndTime = (DateTime)(dr["EndDateTime"])
                };
                activities.Add(activity);
            }
            return activities;
        }

        //remove activity
        public void RemoveActivity(Activity activity)
        {
            try
            {
                OpenConnection();
                string query = "DELETE FROM Activity WHERE [ActivityID]=" + activity.ID;
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Deleting activity failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }
        //add activity
        public void AddActivity(Activity activity)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO Activity (Description, StartDateTime, EndDateTime)" +
                               "VALUES('" + activity.Description + "','" + activity.StartTime + "','" + activity.EndTime + "');";

                string q = "SELECT * FROM Activity " +
                    $"If not exists (Select * from Activity where ActivityID = '{activity.ID}') " +
                    $"BEGIN " +
                    $"Insert into Activity(Description, StartDateTime, EndDateTime) " +
                    $"VALUES('" + activity.Description + "','" + activity.StartTime + "','" + activity.EndTime + "') " +
                    "End";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(q, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Adding activity failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }
        //modify activity
        public void ModifyActivity(Activity activity)
        {
            try
            {
                OpenConnection();
                string query = $"UPDATE [Activity] " +
                    $"SET [Description] = '{activity.Description}', [StartDateTime] = '{activity.StartTime}', [EndDateTime] = '{activity.EndTime}' " +
                    $"WHERE [ActivityID] = '{activity.ID}'";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Updating activity failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
