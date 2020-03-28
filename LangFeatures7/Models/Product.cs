using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LangFeatures7.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }
        public string Name { get; set; }    //This is a property and not a method    {get and set} are the Methods
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; } //= true; now see new Constructor        //read only without the setter set;
        public bool NameBeginsWithS => Name?[0] == 'S';     //page 96
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            kayak.Related = lifejacket;
            return new Product[] { kayak, lifejacket, null };
        }
    }
}
