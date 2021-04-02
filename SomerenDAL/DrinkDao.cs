using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        //returns a list of drinks from database
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT DrinkId, Name, Stock, Price " +     // Select all drinks 
                           "FROM [Drink] " +
                           "WHERE Stock > 1 AND Price > 1 " +          // that have a stock > 1 and price > 1 drinks token
                           "AND Name NOT LIKE '%Water%' " +
                           "AND Name NOT LIKE '%Orange%' " +
                           "AND Name NOT LIKE '%Cherry%'" +            // Do not include the drinks 'Water', 'Orangeade' and 'Cherry juice' in the list.
                           "ORDER BY Stock DESC, Price DESC";          // sorted according to stock, according to sales value + (add drinks sold?)

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    Id = (int)dr["DrinkId"],
                    Name = (string)(dr["Name"].ToString()),
                    Stock = (int)(dr["Stock"]),
                    Price = (int)(dr["Price"])
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        //add drink
        public void AddDrink(Drink drink)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO Drink (Name, Stock, Price)" +
                               "VALUES('" + drink.Name + "','" + drink.Stock + "','" + drink.Price + "') ;";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Adding drinks failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }

        //modify drink
        public void UpdateDrink(Drink drink)
        {
            try
            {
                OpenConnection();
                string query = "UPDATE Drink SET " +
                               "Name='" + drink.Name + "', Price=" + drink.Price + ", Stock=" + drink.Stock + " WHERE [DrinkId]=" + drink.Id;
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Updating drinks failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }

        //remove drink
        public void RemoveDrink(Drink drink)
        {
            try
            {
                OpenConnection();
                string query = "DELETE FROM Drink WHERE [DrinkId]=" + drink.Id;
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Deleting drinks failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
