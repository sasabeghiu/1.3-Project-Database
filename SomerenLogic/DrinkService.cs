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

        public List<Drink> GetDrinks()//get a list with all drinks from db
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
        //adds a drink using the method from dao class
        public void AddDrink(Drink drink)
        {
            drinkdb.AddDrink(drink);
        }
        //updates a drink using the method from dao class
        public void UpdateDrink(Drink drink)
        {
            drinkdb.UpdateDrink(drink);
        }
        //removes a drink using the method from dao class
        public void RemoveDrink(Drink drink)
        {
            drinkdb.RemoveDrink(drink);
        }
    }
}
