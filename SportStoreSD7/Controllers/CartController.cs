using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportStoreSD7.Infrastructure;
using SportStoreSD7.Models;
using SportStoreSD7.Models.ViewModels;

namespace SportStoreSD7.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;
        private Cart cart;                                      //Page 273
        public CartController(IProductRepository repo, Cart cartService)        //Page 273
        {
            repository = repo;
            cart = cartService;
        }
        //public CartController(IProductRepository repo)                //Comment out Page 273.
        //{
        //    repository = repo;
        //}
        public ViewResult Index(string returnUrl)                       //Page 273
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
        //public ViewResult Index1(string returnUrl)                      //Added Index() from Page 273.
        //{
        //    return View(new CartIndexViewModel
        //    {
        //        Cart = GetCart(),
        //        ReturnUrl = returnUrl
        //    });
        //}
        public RedirectToActionResult AddToCart(int productId, string returnUrl)        //Page 274
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        //public RedirectToActionResult AddToCart1(int productId, string returnUrl)        //Added AddToCart() from Page 274
        //{
        //    Product product = repository.Products
        //    .FirstOrDefault(p => p.ProductID == productId);
        //    if (product != null)
        //    {
        //        Cart cart = GetCart();
        //        cart.AddItem(product, 1);
        //        SaveCart(cart);
        //    }
        //    return RedirectToAction("Index", new { returnUrl });

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)       //Page 274.
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        //public RedirectToActionResult RemoveFromCart1(int productId, string returnUrl)      //Added RemoveFromCart() from Page 274
        //{
        //    Product product = repository.Products
        //    .FirstOrDefault(p => p.ProductID == productId);
        //    if (product != null)
        //    {
        //        Cart cart = GetCart();
        //        cart.RemoveLine(product);
        //        SaveCart(cart);
        //    }
        //    return RedirectToAction("Index", new { returnUrl });
        //}
        //private Cart GetCart()                                        //Comment put page 274.
        //{
        //    Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
        //    return cart;
        //}
        //private void SaveCart(Cart cart)
        //{
        //    HttpContext.Session.SetJson("Cart", cart);
        //}
    }
}
