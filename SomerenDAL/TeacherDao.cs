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
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT TeacherId, FirstName, LastName, Supervisor FROM [Teacher]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Number = (int)dr["TeacherId"],
                    FirstName = (string)(dr["FirstName"].ToString()),
                    LastName = (string)(dr["LastName"].ToString()),
                    Supervisor = (string)(dr["Supervisor"].ToString())
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
        //list of supervisors
        public List<Teacher> GetAllSupervisors()
        {
            string query = "SELECT TeacherId, FirstName, LastName, Supervisor FROM [Teacher]" +
                           "WHERE Super LIKE 'y%'"; // selecting the teachers that are supervisors
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //add  supervisors
        public void AddSupervisor(Teacher teacher, Activity activity)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO ActivitySupervisor (ActivityId, TeacherId)" +
                               "VALUES('" + activity.ID + "','" + teacher.Number + "') ;";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Adding supervisors failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }
        //remove supervisors
        public void RemoveSupervisor(Teacher teacher)
        {
            try
            {
                OpenConnection();
                string query = "DELETE FROM Teacher WHERE [TeacherId]=" + teacher.Number;
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Deleting supervisor failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
