using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class TeacherService
    {
        TeacherDao teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacherdb.GetAllTeachers();
            return teachers;
        }
        public List<Teacher> GetSupervisors()
        {
            List<Teacher> supervisors = teacherdb.GetAllSupervisors();
            return supervisors;
        }

        public void AddSupervisor(Teacher teacher, Activity activity)
        {
            teacherdb.AddSupervisor(teacher, activity);
        }

        public void RemoveSupervisor(Teacher teacher)
        {
            teacherdb.RemoveSupervisor(teacher);
        }
    }
}
