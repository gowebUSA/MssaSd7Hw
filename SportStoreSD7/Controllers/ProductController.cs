using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStoreSD7.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportStoreSD7.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private IProductRepository repository;
        public ProductController(IProductRepository repo)   //Page 204.
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Products);
    }
}

/*
using Microsoft.AspNetCore.Mvc;
using SportStoreSD7.Models;

namespace SportStoreSD7.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository repo)   //Page 204.
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Products);
    }
}

 */
