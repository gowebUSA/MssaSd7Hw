using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStoreSD7.Models;

namespace SportStoreSD7.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;                       //Page 287.                 
        private Cart cart;
        public OrderController(IOrderRepository repoService, Cart cartService)  
        {
            repository = repoService;
            cart = cartService;
        }                                                               //Page 287. End.
                                                                        //Page 297 Start.    
        public ViewResult List() =>
            View(repository.Orders.Where(o => !o.Shipped));
        [HttpPost]
        public IActionResult MarkShipped(int orderID)
        {
            Order order = repository.Orders
            .FirstOrDefault(o => o.OrderID == orderID);
            if (order != null)
            {
                order.Shipped = true;
                repository.SaveOrder(order);
            }
            return RedirectToAction(nameof(List));
        }
                                                                        //Page 297. End.            
        public ViewResult Checkout() => View(new Order());          //Original

        [HttpPost]                                                  //Page 287. Start.
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }
        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }                                                               //Page 287. End.
    }
}
