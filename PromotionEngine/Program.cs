using PromotionEngine.Models;
using PromotionEngine.Services.ProductService;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            ProductService productService = new ProductService();

            Console.WriteLine("How many Product you want to add");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter any one of the Product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product(type.ToUpper());
                products.Add(p);
            }

            var totalPrice = productService.GetTotalPrice(products);
            Console.WriteLine("Your total amount for cart is:- " + totalPrice);

        }
    }
}
