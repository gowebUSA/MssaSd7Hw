using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVS7.Models;

namespace WorkingWithVS7.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository = SimpleRepository.SharedRepository;      //Page 177
        //public IActionResult Index()
        //{
        //    return View(SimpleRepository.SharedRepository.Products
        //        .Where(p => p?.Price < 50));    // => / { return }   //Added ? to p to allow null values on page 147.
        //}
        //SimpleRepository Repository = SimpleRepository.SharedRepository;      //Comment out Page 177
        public IActionResult Index() => View(Repository.Products);              //Page 181
        //public IActionResult Index() => View(Repository.Products              //Comment out Page 181
        //.Where(p => p?.Price < 500));
        [HttpGet]
        public IActionResult AddProduct() => View(new Product());
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            Repository.AddProduct(p);
            return RedirectToAction("Index");
        }
    }
}
