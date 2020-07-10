using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Models
{
    public class Promotion
    {
        public int PromoId { get; set; }
        public Dictionary<string, int> ProductInfo { get; set; }
        public decimal PromoPrice { get; set; }

        public Promotion(int _promoID, Dictionary<string, int> _productInfo, decimal _promoPrice)
        {
            this.PromoId = _promoID;
            this.ProductInfo = _productInfo;
            this.PromoPrice = _promoPrice;
        }
    }
}
