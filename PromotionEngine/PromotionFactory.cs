using PromotionEngine.Implementation;
using PromotionEngine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public class PromotionFactory
    {
        public static IEnumerable<IPromotion> GetAppliedPromotions(IList<Cart> cartProducts)
        {
            List<IPromotion> appliedPromotions = new List<IPromotion>();
            if (cartProducts.Count > 0)
            {
                if (cartProducts.Count(a => a.Id.ToUpper() == "A") > 0)
                    appliedPromotions.Add(new Promotion1());
                if (cartProducts.Count(a => a.Id.ToUpper() == "B") > 0)
                    appliedPromotions.Add(new Promotion2());
                if (cartProducts.Count(a => a.Id.ToUpper() == "C" || a.Id.ToUpper() == "D") > 0)
                    appliedPromotions.Add(new Promotion3());
            }
            return appliedPromotions;
        }
    }
}
