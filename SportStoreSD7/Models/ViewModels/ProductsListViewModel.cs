using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportStoreSD7.Models;

namespace SportStoreSD7.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }         //From Dan, Also on Page 237.
    }
}
