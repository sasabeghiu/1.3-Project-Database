using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinkDao drinkdb;
        //basic constructor creating an dao object
        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }
        //get a list with all drinks from db
        public List<Drink> GetDrinks()
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
