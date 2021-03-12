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
    public class DrinkDao : BaseDao
    {
        private SqlConnection conn;
        //returns a list of drinks from database
        public List<Drink> GetAllDrinks() //finish the query(pdf) and ask Mark
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
        public void AddDrink(string name, int stock, int price)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Drink] VALUES(@Stock,@Name,@Price); ", conn);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Price", price);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        //modify drink
        public void UpdateDrink(Drink drink, string name, int stock, int price)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE [Drink] set Stock = @Stock, Name = @Name, Price = @Price where DrinkId = @Id; ", conn);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Id", drink.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }
        //remove drink
        public void RemoveDrink(Drink drink)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Drink WHERE DrinkId=@Id;", conn);
            cmd.Parameters.AddWithValue("@Id", drink.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
        }
    }
}
