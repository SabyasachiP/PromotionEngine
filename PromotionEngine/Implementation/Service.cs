using PromotionEngine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
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
            decimal totalPrice = default;
            try
            {
                _appliedPromotions.ToList().ForEach(a => totalPrice += a.GetPrice(order));
            }
            catch (Exception ex)
            {

            }
            return totalPrice;
        }
    }
}
