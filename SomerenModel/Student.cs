using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Student
    { 
        public string FirstName { get; set; } //first name
        public string LastName { get; set; } //last name
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public DateTime BirthDate { get; set; }  //date of birth
    }
}
