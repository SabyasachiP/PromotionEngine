using PromotionEngine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Implementation
{
    public class Promotion1 : IPromotion
    {
        private readonly decimal _priceOfA = Units.Detail["A"];
        public decimal GetPrice(IEnumerable<Cart> units)
        {
            decimal price = default;
            int countofUnit = default;
            try
            {
                units.ToList().ForEach(a =>
                {
                    if (a.Id.ToUpper() == "A")
                    {
                        countofUnit += 1;
                    }
                });

                price = (countofUnit / 3) * 130 + (countofUnit % 3 * _priceOfA);
            }
            catch (Exception ex)
            {

            }
            return price;
        }
    }
}
