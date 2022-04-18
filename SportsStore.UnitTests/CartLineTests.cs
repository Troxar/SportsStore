using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.Domain.Entities;

namespace SportsStore.UnitTests
{
    [TestClass]
    public class CartLineTests
    {
        [TestMethod]
        public void Calculate_Line_Value()
        {
            // Arrange
            Product p1 = new Product { ProductID = 1, Name = "P1", Price = 100M };
            Product p2 = new Product { ProductID = 2, Name = "P2", Price = 50M };

            CartLine target0 = new CartLine();
            CartLine target1 = new CartLine { Product = p1, Quantity = 2 };
            CartLine target2 = new CartLine { Product = p2, Quantity = 3 };

            // Act
            decimal result0 = target0.ComputeValue();
            decimal result1 = target1.ComputeValue();
            decimal result2 = target2.ComputeValue();

            // Assert
            Assert.AreEqual(result0, 0M);
            Assert.AreEqual(result1, 200M);
            Assert.AreEqual(result2, 150M);
        }
    }
}
