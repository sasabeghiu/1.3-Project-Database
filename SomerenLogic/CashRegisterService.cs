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
using SomerenDAL;

namespace SomerenLogic
{
    public class CashRegisterService
    {
        StudentDao student;
        DrinkDao drink;

        public CashRegisterService()
        {
            student = new StudentDao();
            drink = new DrinkDao();
        }

        public void AddStudentDrink(Student student, Drink drink)
        {
            CashRegisterDao studentDrink = new CashRegisterDao();
            studentDrink.AddStudentDrink(student, drink);
        }
    }
}
