using PromotionEngine.Models;
using PromotionEngine.Services.ProductService;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.ServiceTests
{
    public class ProductServiceTests
    {
        [Theory]
        [InlineData("ABC", 100)]
        [InlineData("AAAAABBBBBC", 370)]
        [InlineData("AAABBBBBCD", 280)]
        public void TestGetProductPrice(string productsString, decimal expectedPrice)
        {
            List<Product> products = new List<Product>();
            foreach(var prod in productsString)
            {
                products.Add(new Product(prod.ToString()));
            }

            ProductService productService = new ProductService();
            var actualPrice = productService.GetTotalPrice(products);

            Assert.Equal(expectedPrice, actualPrice);
        }
    }
}
