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
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT StudentId, FirstName, LastName, DateOfBirth FROM [Student]"; // selecting the information we need from database
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["StudentId"], //assigning the data to the properties in model class
                    FirstName = (string)(dr["FirstName"].ToString()),
                    LastName = (string)(dr["LastName"].ToString()),
                    BirthDate = (DateTime)(dr["DateOfBirth"])
                };
                students.Add(student);
            }
            return students;
        }
        //list of participants
        public List<Student> GetAllParticipants()
        {
            string query = "SELECT StudentId, FirstName, LastName, DateOfBirth FROM [Student]" +
                           "WHERE Participant LIKE 'y%'"; // selecting the students that are participants
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //add participant
        public void AddParticipant(Student student, Activity activity)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO ActivityStudent (ActivityId, StudentId)" +
                               "VALUES('" + activity.ID + "','" + student.Number + "') ;";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Adding participants failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }
        //remove participant
        public void RemoveParticipant(Student student)
        {
            try
            {
                OpenConnection();
                string query = "DELETE FROM Student WHERE [StudentId]=" + student.Number;
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Deleting participant failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
