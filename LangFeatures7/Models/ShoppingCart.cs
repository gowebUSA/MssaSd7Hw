using System.Collections;
using System.Collections.Generic;
namespace LangFeatures7.Models
{
    public class ShoppingCart : IEnumerable<Product>
    {
        //Page 85
        //public IEnumerable<Product> Products { get; set; }

        //Page 87
        public IEnumerable<Product> Products { get; set; }
        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
