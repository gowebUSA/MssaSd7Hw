using System;
using System.Collections.Generic;
using System.Text;
using WorkingWithVS7.Models;
using Xunit;

namespace WorkingWithVS7.Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeProductName()
        {
            // Arrange                  //See page 171 of ASP.NET book for list of test attributes.
            var p = new Product { Name = "Test", Price = 100M };
            // Act
            p.Name = "New Name";
            //Assert
            Assert.Equal("New Name", p.Name);
        }
        [Fact]
        public void CanChangeProductPrice()
        {
            // Arrange
            var p = new Product { Name = "Test", Price = 100M };
            // Act
            p.Price = 200M;
            //Assert
            Assert.Equal(200M, p.Price);
        }
    }
}

