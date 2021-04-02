
namespace SomerenModel
{
    public class Drink
    {
        public int Id { get; set; } //drink ID
        public string Name { get; set; } //drink name
        public int Stock { get; set; } //amount of drink
        public int Price { get; set; } // sales price

        //basic constructor
        public Drink() 
        {

        }
        //calculated readonly property for displaying a text if stock > || < 10
        public string StockInfo
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
