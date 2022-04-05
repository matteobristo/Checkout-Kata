using Kata.Biz;
using System.Collections.Generic;
using Xunit;

namespace Kata.Tests
{
    public class AddItemsToBasketTests
    {
        private Cart cart;

        public AddItemsToBasketTests()
        {
            cart = new Cart(new PromotionsProcessor(new List<IPromotion>()));
        }

        [Fact]
        public void TestForEmptyCart()
        {
            Assert.True(cart.CartItems.Count == 0);
        }


        [Fact]
        public void AddSingleItemToCart()
        {
            Item item = new Item('A', 10);
            
            cart.AddToCart(item);

            Assert.All(cart.CartItems, item => Assert.Contains(item.SKU, "A"));
            Assert.True(cart.CartItems.Count == 1);
        }

        [Fact]
        public void AddTwoItemsToCart()
        {
            Item itemA = new Item('A', 10);
            Item itemB = new Item('B', 15);
            
            cart.AddToCart(itemA);
            cart.AddToCart(itemB);

            Assert.Contains(itemA, cart.CartItems);
            Assert.Contains(itemB, cart.CartItems);
            Assert.True(cart.CartItems.Count == 2);
        }
    }
}