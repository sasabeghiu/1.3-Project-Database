using System;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class CashRegisterDao : BaseDao
    {
        //adding the drink that a student bought to database
        public void AddStudentDrink(Student student, Drink drink)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO StudentDrink (StudentId, StudentName, DrinkId, DrinkName, DrinkStock, DrinkPrice)" +
                "VALUES('" + student.Number + "','" + student.FirstName + "','" + drink.Id + "','" + drink.Name + "','" + drink.Stock + "','" + drink.Price + "') ;";

                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Adding student drinks failed!" + exp);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
