using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStoreSD7.Models;

namespace SportStoreSD7.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IProductRepository repository;                          //Page 248.
        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()                            //Page 248.
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];       //Page 251.
            return View(repository.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }
        public string Invoke1()
        {
            return "Hello from the Nav View Component";
        }
    }
}
