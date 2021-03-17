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

        public DrinkService() //basic constructor creating an dao object
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks() //get a list with all drinks from db
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
       
        public void AddDrink(Drink drink) //adds a drink using the method from dao class
        {
            drinkdb.AddDrink(drink);
        }
        
        public void UpdateDrink(Drink drink) //updates a drink using the method from dao class
        {
            drinkdb.UpdateDrink(drink);
        }
        
        public void RemoveDrink(Drink drink) //removes a drink using the method from dao class
        {
            drinkdb.RemoveDrink(drink);
        }
    }
}
