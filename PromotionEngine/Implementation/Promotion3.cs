using PromotionEngine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Implementation
{
    public class Promotion3 : IPromotion
    {
        private readonly decimal _priceOfC = Units.Detail["C"];
        private readonly decimal _priceOfD = Units.Detail["D"];
        public decimal GetPrice(IEnumerable<Cart> units)
        {
            decimal price = default;
            int countofC = default;
            int countofD = default;
            try
            {
                units.ToList().ForEach(a =>
                {
                    if (a.Id.ToUpper() == "C")
                    {
                        countofC += 1;
                    }
                    else if (a.Id.ToUpper() == "D")
                    {
                        countofD += 1;
                    }
                });

                if (countofC > 0 && countofD > 0)
                {
                    int totalCount = countofC + countofD;
                    int residual = totalCount % 2;
                    if (totalCount >= 2)
                    {
                        price = ((totalCount / 2) * 30) + (residual > 0 ? (((countofC - (totalCount % 2)) * _priceOfC) + ((countofD - (totalCount % 2)) * _priceOfD)) : 0);
                    }
                }
                else if (countofC > 0)
                {
                    price = countofC * _priceOfC;
                }
                else if (countofD > 0)
                {
                    price = countofD * _priceOfD;
                }
            }
            catch (Exception ex)
            {

            }
            return price;
        }
    }
}
