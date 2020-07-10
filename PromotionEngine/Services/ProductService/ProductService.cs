using PromotionEngine.Models;
using PromotionEngine.Services.PromotionService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Services.ProductService
{
    public class ProductService : IProductServcie
    {
        public readonly IPromotionService promotionService;

        public ProductService()
        {
            promotionService = new PromotionService.PromotionService();
        }

        public decimal GetTotalPrice(List<Product> products)
        {
            decimal origprice = products.Sum(x => x.Price);

            var promotions = promotionService.GetAllPromotions();
            List<decimal> promoprices = promotions
            .Select(promo => GetTotalPriceWithPromotions(products, promo))
            .ToList();

            return origprice - promoprices.Sum();
        }

        public decimal GetTotalPriceWithPromotions(List<Product> products, Promotion prom)
        {
            decimal d = 0M;

            var promotedProdCount = products
                .GroupBy(x => x.Id)
                .Where(grp => prom.ProductInfo.Any(y => grp.Key == y.Key && grp.Count() >= y.Value))
                .Select(grp => grp.Count())
                .Sum();

            int promotedProdPromotion = prom.ProductInfo.Sum(kvp => kvp.Value);
            while (promotedProdCount >= promotedProdPromotion)
            {
                d += prom.PromoPrice;
                promotedProdCount -= promotedProdPromotion;
            }
            return d;
        }
    }
}
