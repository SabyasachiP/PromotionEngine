using PromotionEngine.Implementation;
using PromotionEngine.Interface;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cart> cartProducts = new List<Cart>();

            Console.WriteLine("Please provide the total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Please enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                if (Units.Detail.ContainsKey(type.ToUpper()))
                {
                    Cart od = new Cart(type);
                    cartProducts.Add(od);
                }
            }

            IEnumerable<IPromotion> appliedPromotions = PromotionFactory.GetAppliedPromotions(cartProducts);
            IService service = new Service(appliedPromotions);

            decimal totalPrice = service.GetTotalOrderPrice(cartProducts);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}
