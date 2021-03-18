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
    public class CashRegisterDao : BaseDao
    {

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
