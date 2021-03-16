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
    public class DrinkDao : BaseDao
    {
        private SqlConnection dbConnection;
        //returns a list of drinks from database
        public List<Drink> GetAllDrinks()                                       //finish the query(pdf) and ask Mark
        {
            string query = "SELECT DrinkId, Name, Stock, Price " +              // Select all drinks 
                           "FROM [Drink] " +
                           "WHERE Stock > 1 AND Price > 1 " +                   // that have a stock > 1 and price > 1 drinks token
                           "AND Name NOT LIKE '%Water%' " +
                           "AND Name NOT LIKE '%Orange%' " +
                           "AND Name NOT LIKE '%Cherry%'" +                     // Do not include the drinks 'Water', 'Orangeade' and 'Cherry juice' in the list.
                           "ORDER BY Stock DESC, Price DESC";                   // sorted according to stock, according to sales value + (add drinks sold?)

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
                /*SqlCommand command = new SqlCommand("INSERT INTO Drink (Id, Name, Stock, Price) VALUES (@Id, @Name, @Stock, @Price); " +
                    "SELECT SCOPE_IDENTITY();", dbConnection);
                command.Parameters.AddWithValue("@Id", drink.Id);
                command.Parameters.AddWithValue("@Stock", drink.Stock);
                command.Parameters.AddWithValue("@Name", drink.Name);
                command.Parameters.AddWithValue("@Price", drink.Price);
                //drink.Id = Convert.ToInt32(command.ExecuteScalar());*/

                string query = "INSERT INTO Drink" +
                               "VALUES(DrinkId" + drink.Id + ", Name" + drink.Name + ", Stock" + drink.Stock + ", Price" + drink.Price + ")";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Adding drinks failed!");
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
                /*SqlCommand command = new SqlCommand("UPDATE Drink SET Stock = @Stock, Name = @Name, Price = @Price WHERE DrinkId = @DrinkId; ", dbConnection);
                command.Parameters.AddWithValue("@Stock", drink.Stock);
                command.Parameters.AddWithValue("@Name", drink.Name);
                command.Parameters.AddWithValue("@Price", drink.Price);
                command.Parameters.AddWithValue("@DrinkId", drink.Id);*/

                string query = "UPDATE Drink SET Name='" + drink.Name + "', Price=" + drink.Price + ", Stock=" + drink.Stock + " WHERE [DrinkId]=" + drink.Id;
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Updating drinks failed!");
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
                //SqlCommand command = new SqlCommand("DELETE FROM Drink WHERE DrinkId = @DrinkId", dbConnection);
                //command.Parameters.AddWithValue("@DrinkId", drink.Id);

                string query = "DELETE FROM Drink WHERE [DrinkId]=" + drink.Id;
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Deleting drinks failed!");
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
