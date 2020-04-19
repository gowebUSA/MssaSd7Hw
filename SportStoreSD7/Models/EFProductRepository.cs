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
        public void SaveProduct(Product product)
        {
            if (product.ProductID == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry = context.Products
                .FirstOrDefault(p => p.ProductID == product.ProductID);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            context.SaveChanges();
        }
    }
}
