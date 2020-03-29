using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStoreSD7.Models
{
    public class EFProductRepository : IProductRepository               //Interface - make sure its public
    {
        private ApplicationDbContext context;
        public EFProductRepository(ApplicationDbContext ctx)            //public class constructor
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
