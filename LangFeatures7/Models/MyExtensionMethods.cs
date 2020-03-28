using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LangFeatures7.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            //Page 87
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
        public static IEnumerable<Product> Filter(
            this IEnumerable<Product> productEnum,
            Func<Product, bool> selector)
        {
            foreach (Product prod in productEnum)
            {
                if (selector(prod))
                {
                    yield return prod;
                }
            }
        }
        
        //commented out on page 92
        //Added on page 89
        //Used on Index9();
        public static IEnumerable<Product> FilterByPrice(               
            this IEnumerable<Product> productEnum, decimal minimumPrice)
        {
            foreach (Product prod in productEnum)
            {
                if ((prod?.Price ?? 0) >= minimumPrice)
                {
                    yield return prod;
                }
            }
        }
        // end comment on page 92


        //commented out on page __
        //Added on page 90
        //Used on Index10();
        public static IEnumerable<Product> FilterByName(
            this IEnumerable<Product> productEnum, char firstLetter)
        {
            foreach (Product prod in productEnum)
            {
                if (prod?.Name?[0] == firstLetter)
                {
                    yield return prod;
                }
            }
        }
        // end comment on page __

        //public static decimal TotalPrices(this ShoppingCart cartParam)
        //{
        //    //Page 85
        //    decimal total = 0;
        //    foreach (Product prod in cartParam.Products)
        //    {
        //        total += prod?.Price ?? 0;
        //    }
        //    return total;
        //}
    }
}
