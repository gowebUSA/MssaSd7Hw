using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Moq;
using SportStoreSD7.Controllers;
using SportStoreSD7.Models;
using Xunit;
using SportStoreSD7.Models.ViewModels;

namespace SportStoreSD7.Test
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Send_Pagination_View_Model()
        {
            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"},
                new Product {ProductID = 3, Name = "P3"},
                new Product {ProductID = 4, Name = "P4"},
                new Product {ProductID = 5, Name = "P5"}
            }).AsQueryable<Product>());

            // Arrange
            ProductController controller =
                new ProductController(mock.Object) { PageSize = 3 };

            // Act
            ProductsListViewModel result =
                controller.List(null, 2).ViewData.Model as ProductsListViewModel;   //Added  null from Page 240.

            // Assert
            PagingInfo pageInfo = result.PagingInfo;
            Assert.Equal(2, pageInfo.CurrentPage);
            Assert.Equal(3, pageInfo.ItemsPerPage);
            Assert.Equal(5, pageInfo.TotalItems);
            Assert.Equal(2, pageInfo.TotalPages);
        }
        [Fact]
        public void Can_Paginate()
        {
            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"},
                new Product {ProductID = 3, Name = "P3"},
                new Product {ProductID = 4, Name = "P4"},
                new Product {ProductID = 5, Name = "P5"}
            }).AsQueryable<Product>());

            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            // Act
            ProductsListViewModel result =
                controller.List(null, 2).ViewData.Model as ProductsListViewModel;
                //controller.List(2).ViewData.Model as ProductsListViewModel;     //Page 226. Comment out page 239.
            //IEnumerable<Product> result =                                     //Comment out Page 226.
            //    controller.List(2).ViewData.Model as IEnumerable<Product>;

            // Assert
            Product[] prodArray = result.Products.ToArray();                    //Page 226.
            //Product[] prodArray = result.ToArray();                           //Comment out Page 226.
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);
        }
    }
}
