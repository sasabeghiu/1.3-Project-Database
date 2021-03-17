using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int Id { get; set; } //drink ID
        public string Name { get; set; } //drink name
        public int Stock { get; set; } //amount of drink
        public int Price { get; set; } // sales price
        public Drink() //basic ctor
        {

        }
        public string StockInfo //calculated readonly property for displaying a text if stock > || < 10
        {
            get
            {
                string value = "";
                if (Stock < 10)
                {
                    value = "Stock nearly deleted";
                }
                else
                {
                    value = "Stock sufficient";
                }
                return value;
            }
        }
    }
}
