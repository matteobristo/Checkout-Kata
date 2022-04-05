using Kata.Biz;
using System.Collections.Generic;
using Xunit;

namespace Kata.Tests
{
    public class CalculateCostOfCartTests
    {
        private Cart cart;

        public CalculateCostOfCartTests()
        {
            cart = new Cart(new PromotionsProcessor(new List<IPromotion>()));
        }

        [Fact]
        public void CalculateCostOfEmptyCart()
        {
            Assert.Equal(0, cart.Total);
        }

        [Fact]
        public void CalculateCostOfSingleProduct()
        {

            var item1 = new Item('A', 10);

            cart.AddToCart(item1);

            Assert.Equal(10, cart.Total);
        }

        [Fact]
        public void CalculateCostOfTwoProducts()
        {

            var item1 = new Item('A', 10);
            var item2 = new Item('B', 15);

            cart.AddToCart(item1);
            cart.AddToCart(item2);

            Assert.Equal(25, cart.Total);
        }

        [Fact]
        public void CalculateCostOfMultipleProductsWithPence()
        {
            var item1 = new Item('A', 10.25M);
            var item2 = new Item('B', 15.50M);

            cart.AddToCart(item1);
            cart.AddToCart(item2);

            Assert.Equal(25.75M, cart.Total);
        }
    }
}
