using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LangFeatures7.Models;
using System.Threading.Tasks;

namespace LangFeatures7.Coontrollers
{
    public class HomeController : Controller
    {
        bool FilterByPrice(Product p)   //from page 92
        {
            return (p?.Price ?? 0) >= 20;
        }
        public ViewResult Index()
        {
            var products = new[] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
};
            return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
        }
        public async Task<ViewResult> Index18()
        {
            //Page 102, not showing correct ans.
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });
        }
        public ViewResult Index17()
        {
            var products = new[] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
        };
            return View(products.Select(p => p.GetType().Name));
        }
        public ViewResult Index16()
        {
            var products = new[] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
        };
            return View(products.Select(p => p.Name));
        }
        public ViewResult Index15()
        {
            // page 97
            var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
            return View(names);
        }
        public ViewResult Index14() =>
        View(Product.GetProducts().Select(p => p?.Name));       //page 95
        public ViewResult Index13()
        {
            //Page 95
            return View(Product.GetProducts().Select(p => p?.Name));
        }
        public ViewResult Index12()
        {
            //Page 93
            ShoppingCart cart
            = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},  
                new Product {Name = "Corner flag", Price = 34.95M}  
            };

            Func<Product, bool> nameFilter = delegate (Product prod)   
            {
                return prod?.Name?[0] == 'S';
            };

            decimal priceFilterTotal = productArray
                .Filter(p => (p?.Price ?? 0) >= 20) //added on page 93
                .TotalPrices();
            decimal nameFilterTotal = productArray
                .Filter(p => p?.Name?[0] == 'S')   //added on page 94
                .TotalPrices();                                        

            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}" });
        }
        public ViewResult Index11()
        {
            //Page 93
            ShoppingCart cart
            = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},  
                new Product {Name = "Corner flag", Price = 34.95M}  
            };

            Func<Product, bool> nameFilter = delegate (Product prod)   
            {
                return prod?.Name?[0] == 'S';
            };

            decimal priceFilterTotal = productArray
                .Filter(FilterByPrice)          //commented out on page 93
                .TotalPrices();
            decimal nameFilterTotal = productArray
                .Filter(nameFilter)             //commented out on page 94
                .TotalPrices();

            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}" });
        }
        public ViewResult Index10()
        {
            //Page 91
            ShoppingCart cart
            = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
            decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();
            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}" });
        }
        public ViewResult Index9()
        {
            //Page 89
            ShoppingCart cart
            = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M}, 
                new Product {Name = "Corner flag", Price = 34.95M} 
            };

            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();     
            return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
        }
        public ViewResult Index8()
        {
            // Page 87-88
            ShoppingCart cart
            = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
            };

            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.TotalPrices();
            return View("Index", new string[] {
                $"Cart Total: {cartTotal:C2}",
                $"Array Total: {arrayTotal:C2}" });
        }
        public ViewResult Index7()
        {
            //Page 86
            ShoppingCart cart
            = new ShoppingCart { Products = Product.GetProducts() };
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
        }
        public ViewResult Index6()
        {
            //Page 84
            object[] data = new object[] { 275M, 29.95M,
            "apple", "orange", 100, 10 };
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }
        public ViewResult Index5()
        {
            //Page 83
            object[] data = new object[] { 275M, 29.95M,
            "apple", "orange", 100, 10 };
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    total += d;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }
        public ViewResult Index4()
        {
            //Page 82
            Dictionary<string, Product> products =
                new Dictionary<string, Product>
                {
                    //{"kayak", new Product{Name="Kayak", Price=375M} },
                    //{"lifejaket", new Product{ Name="PFD", Price=50.95M } }
                    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
                    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
                };
            return View("Index", products.Keys);
        }
        public ViewResult Index3()
        {
            string[] names = new string[3];
            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Alice";
            return View("Index", names);
        }
        public ViewResult Index2()
        {
            //return View(new string[] { "C#", "Language", "Features" });
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name;    // ? nullable
                decimal? price = p?.Price;
                string relatedItem = p?.Related?.Name ?? "<None>";         // ?? null coalescing operator
                results.Add(string.Format(
                    $"Name: {name}," +              //We use sring interppoaltion instead of using array positioning.
                    $"Price: {price}," + 
                    $"Related : {relatedItem}"));       //, name, price, relatedItem
            }
            return View(results);
        }
    } 
}
