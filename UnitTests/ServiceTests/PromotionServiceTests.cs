using Newtonsoft.Json;
using PromotionEngine.Models;
using PromotionEngine.Services.PromotionService;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.ServiceTests
{
    public class PromotionServiceTests
    {
        [Fact]
        public void TestGetAllPromotions()
        {
            Dictionary<String, int> promoProduct1 = new Dictionary<String, int>();
            promoProduct1.Add("A", 3);
            Dictionary<String, int> promoProduct2 = new Dictionary<String, int>();
            promoProduct2.Add("B", 2);
            Dictionary<String, int> promoProduct3 = new Dictionary<String, int>();
            promoProduct3.Add("C", 1);
            promoProduct3.Add("D", 1);

            List<Promotion> expectedPromotions = new List<Promotion>()
            {
                new Promotion(1, promoProduct1, 20),
                new Promotion(2, promoProduct2, 15),
                new Promotion(3, promoProduct3, 5)
            };

            var promotionService = new PromotionService();
            var actualPromotions = promotionService.GetAllPromotions();

            Assert.NotNull(actualPromotions);
            Assert.Equal(JsonConvert.SerializeObject(expectedPromotions), JsonConvert.SerializeObject(actualPromotions));
        }
    }
}
