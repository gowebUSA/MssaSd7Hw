using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStoreSD7.Models;
using SportStoreSD7.Models.ViewModels;

//KEEP THIS ONE. This is the original made from the book. DO NOT DELETE.
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
        public int PageSize = 7;
        public ProductController(IProductRepository repo)   //Page 204.
        {
            repository = repo;
        }
        public ViewResult List(string category, int productPage = 1)                 //Page 225.
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    //TotalItems = repository.Products.Count()
                    TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e =>
                        e.Category == category).Count()
                },
                CurrentCategory = category
            });
        public ViewResult List3(int productPage = 1)                 //Page 225.
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
        public ViewResult List2(int productPage = 1)                //Page 219. //Cmment out on page 225.
            => View(repository.Products
            .OrderBy(p => p.ProductID)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize));
        public ViewResult List1() => View(repository.Products);    //Cmment out on page 219.
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