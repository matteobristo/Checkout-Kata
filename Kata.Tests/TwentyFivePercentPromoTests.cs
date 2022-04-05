using Kata.Biz;
using System.Collections.Generic;
using Xunit;

namespace Kata.Tests
{
    public class TwentyFivePercentPromoTests
    {
        private Cart cart;

        public TwentyFivePercentPromoTests()
        {
            cart = new Cart(new PromotionsProcessor(new List<IPromotion>() { new TwentyFivePercentPromo() }));
        }

        [Fact]
        public void WhenOneItemNoPromotionApplied()
        {
            Item item1 = new Item('D', 55);
            
            // act
            cart.AddToCart(item1);
            
            // assert
            Assert.Equal(55M, cart.Total);
        }

        [Fact]
        public void WhenTwoItemPromotionApplied()
        {
            //TwentyFivePercentPromo

            Item item1 = new Item('D', 55);
            Item item2 = new Item('D', 55);

            // act
            cart.AddToCart(item1);
            cart.AddToCart(item2);

            // assert
            Assert.Equal(82.5M, cart.Total);
        }

        [Fact]
        public void WhenThreeItemPromotionAppliedToTwo()
        {
            //TwentyFivePercentPromo

            Item item1 = new Item('D', 55);
            Item item2 = new Item('D', 55);
            Item item3 = new Item('D', 55);

            // act
            cart.AddToCart(item1);
            cart.AddToCart(item2);
            cart.AddToCart(item3);

            // assert
            Assert.Equal(137.5M, cart.Total);
        }

        [Fact]
        public void WhenFourItemPromotionAppliedTwice()
        {
            //TwentyFivePercentPromo

            Item item1 = new Item('D', 55);
            Item item2 = new Item('D', 55);
            Item item3 = new Item('D', 55);
            Item item4 = new Item('D', 55);

            // act
            cart.AddToCart(item1);
            cart.AddToCart(item2);
            cart.AddToCart(item3);
            cart.AddToCart(item4);

            // assert
            Assert.Equal(165M, cart.Total);
        }
    }
}
