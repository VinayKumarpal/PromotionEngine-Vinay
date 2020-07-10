using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    public class CartProduct
    {
        public int CartId { get; set; }
        public List<Product> Products { get; set; }

        public CartProduct(int _cartId, List<Product> _prods)
        {
            this.CartId = _cartId;
            this.Products = _prods;
        }
    }
}
