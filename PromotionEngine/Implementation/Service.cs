using PromotionEngine.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Implementation
{
    public class Service : IService
    {
        private readonly IEnumerable<IPromotion> _appliedPromotions;
        public Service(IEnumerable<IPromotion> appliedPromotions)
        {
            _appliedPromotions = appliedPromotions;
        }
        public decimal GetTotalOrderPrice(IEnumerable<Cart> order)
        {
            throw new NotImplementedException();
        }
    }
}
