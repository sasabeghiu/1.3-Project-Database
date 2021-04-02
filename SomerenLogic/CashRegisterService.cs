using SomerenModel;
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
        //add the drink and the student that bought it to database
        public void AddStudentDrink(Student student, Drink drink)
        {
            CashRegisterDao studentDrink = new CashRegisterDao();
            studentDrink.AddStudentDrink(student, drink);
        }
    }
}
