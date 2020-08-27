using NUnit.Framework;
using PromotionEngine.Implementation;
using PromotionEngine.Interface;
using System.Collections.Generic;

namespace PromotionEngine.Test
{
    public class Tests
    {
        private IService _service;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Scenario1()
        {
            List<Cart> orderCart = new List<Cart>() { new Cart("A"), new Cart("B"), new Cart("C") };
            IEnumerable<IPromotion> enumerable = PromotionFactory.GetAppliedPromotions(orderCart);
            _service = new Service(enumerable);
            decimal expectedValue = 100;
            decimal actualValue = _service.GetTotalOrderPrice(orderCart);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Scenario2()
        {
            List<Cart> orderCart = new List<Cart>() { new Cart("A"), new Cart("A"), new Cart("A"), new Cart("A"), new Cart("A"), new Cart("B"), new Cart("B"), new Cart("B"), new Cart("B"), new Cart("B"), new Cart("C") };
            IEnumerable<IPromotion> enumerable = PromotionFactory.GetAppliedPromotions(orderCart);
            _service = new Service(enumerable);
            decimal expectedValue = 370;
            decimal actualValue = _service.GetTotalOrderPrice(orderCart);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void Scenario3()
        {
            List<Cart> orderCart = new List<Cart>() { new Cart("A"), new Cart("A"), new Cart("A"), new Cart("B"), new Cart("B"), new Cart("B"), new Cart("B"), new Cart("B"), new Cart("C"), new Cart("D") };
            IEnumerable<IPromotion> enumerable = PromotionFactory.GetAppliedPromotions(orderCart);
            _service = new Service(enumerable);
            decimal expectedValue = 280;
            decimal actualValue = _service.GetTotalOrderPrice(orderCart);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void Scenario4()
        {
            List<Cart> orderCart = new List<Cart>() { new Cart("C"), new Cart("D") };
            IEnumerable<IPromotion> enumerable = PromotionFactory.GetAppliedPromotions(orderCart);
            _service = new Service(enumerable);
            decimal expectedValue = 30;
            decimal actualValue = _service.GetTotalOrderPrice(orderCart);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void Scenario5()
        {
            List<Cart> orderCart = new List<Cart>() { new Cart("C"), new Cart("D"), new Cart("D") };
            IEnumerable<IPromotion> enumerable = PromotionFactory.GetAppliedPromotions(orderCart);
            _service = new Service(enumerable);
            decimal expectedValue = 45;
            decimal actualValue = _service.GetTotalOrderPrice(orderCart);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void Scenario6()
        {
            List<Cart> orderCart = new List<Cart>() { new Cart("C"), new Cart("C"), new Cart("D"), new Cart("D") };
            IEnumerable<IPromotion> enumerable = PromotionFactory.GetAppliedPromotions(orderCart);
            _service = new Service(enumerable);
            decimal expectedValue = 60;
            decimal actualValue = _service.GetTotalOrderPrice(orderCart);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}