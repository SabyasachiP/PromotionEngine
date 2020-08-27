using PromotionEngine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Implementation
{
    public class Promotion2 : IPromotion
    {
        private readonly decimal _priceOfB = Units.Detail["B"];
        public decimal GetPrice(IEnumerable<Cart> units)
        {
            decimal price = default;
            int countofUnit = default;
            try
            {
                units.ToList().ForEach(a =>
                {
                    if (a.Id.ToUpper() == "B")
                    {
                        countofUnit += 1;
                    }
                });

                price = (countofUnit / 2) * 45 + (countofUnit % 2 * _priceOfB);

            }
            catch (Exception ex)
            {

            }
            return price;
        }
    }
}
