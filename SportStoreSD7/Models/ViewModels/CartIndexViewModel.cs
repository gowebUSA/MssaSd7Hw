using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportStoreSD7.Models;

namespace SportStoreSD7.Models.ViewModels
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
