using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Services.PromotionService
{
    public interface IPromotionService
    {
        List<Promotion> GetAllPromotions();
    }
}
