using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class StudentService
    {
        StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = studentdb.GetAllStudents();
            return students;
        }

        public List<Student> GetParticipants()
        {
            List<Student> students = studentdb.GetAllParticipants();
            return students;
        }

        public void AddParticipant(Student student, Activity activity)
        {
            studentdb.AddParticipant(student, activity);
        }

        public void RemoveParticipant(Student student)
        {
            studentdb.RemoveParticipant(student);
        }
    }
}
