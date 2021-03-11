using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
        //adds a drink using the method from dao class
        public void AddDrink(string name, int stock, int price)
        {
            drinkdb.AddDrink(name, stock, price);
        }
        //updates a drink using the method from dao class
        public void UpdateDrink(Drink drink, string name, int stock, int price)
        {
            drinkdb.UpdateDrink(drink, name, stock, price);
        }
        //removes a drink using the method from dao class
        public void RemoveDrink(Drink drink)
        {
            drinkdb.RemoveDrink(drink);
        }
    }
}
