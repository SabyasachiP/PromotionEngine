using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Interface
{
    public interface IService
    {
        decimal GetTotalOrderPrice(IEnumerable<Cart> order);
    }
}
