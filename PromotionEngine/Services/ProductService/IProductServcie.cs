using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Services.ProductService
{
    public interface IProductServcie
    {
        decimal GetTotalPrice(List<Product> products);
    }
}
