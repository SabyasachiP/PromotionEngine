using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class Cart
    {
        public string Id { get; set; }
        public decimal Price { get; private set; }

        public Cart(string id)
        {
            this.Id = id;
            this.Price = Units.Detail[id.ToUpper()];
        }
    }

    public class Units
    {
        public static Dictionary<string, decimal> Detail
        {
            get
            {
                return new Dictionary<string, decimal>
                    {
                        { "A",50m}
                       ,{ "B",30m}
                       ,{ "C",20m}
                       ,{ "D",15m}
                    };
            }
        }
    }
}
