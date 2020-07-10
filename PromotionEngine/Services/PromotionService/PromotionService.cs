using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Services.PromotionService
{
    public class PromotionService : IPromotionService
    {
        public List<Promotion> GetAllPromotions()
        {
            Dictionary<String, int> promoProduct1 = new Dictionary<String, int>();
            promoProduct1.Add("A", 3);
            Dictionary<String, int> promoProduct2 = new Dictionary<String, int>();
            promoProduct2.Add("B", 2);
            Dictionary<String, int> promoProduct3 = new Dictionary<String, int>();
            promoProduct3.Add("C", 1);
            promoProduct3.Add("D", 1);

            List<Promotion> promotions = new List<Promotion>()
            {
                new Promotion(1, promoProduct1, 20),    // Total discount is A => 50*3 - 130 = 20(Promotion Applied amount)
                new Promotion(2, promoProduct2, 15),    // Total discount is B => 30*2 - 45 = 15(Promotion Applied amount)
                new Promotion(3, promoProduct3, 5)      // Total discount is C + D => 15 + 20 - 30 = 5(Promotion Applied amount)
            };

            return promotions;
        }
    }
}
