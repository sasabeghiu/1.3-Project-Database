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
    }
}
