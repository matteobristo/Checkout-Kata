using Kata.Biz;
using System.Collections.Generic;
using Xunit;

namespace Kata.Tests
{
    public class ThreeForFortyPromotionTests
    {

        [Fact]
        public void NoDiscountAppliedToEmptyCart()
        {
            var cart = new Cart(new PromotionsProcessor(new List<IPromotion>()));
           
            Assert.Equal(0, cart.Total);
        }

        [Fact]
        public void NoDiscountAppliedToNonQualifyingItems()
        {
            var cart = new Cart(new PromotionsProcessor(new List<IPromotion>()));
            var item1 = new Item('A', 10);
            var item2 = new Item('A', 10);
            var item3 = new Item('A', 10);

            // act
            cart.AddToCart(item1);
            cart.AddToCart(item2);
            cart.AddToCart(item3);

            // assert
            Assert.Equal(30, cart.Total);
        }

        [Fact]
        public void DiscountAppliedTo3Items()
        {
            List<IPromotion> promotions = new List<IPromotion> { new ThreeForFortyPromo() };
            var processor = new PromotionsProcessor(promotions);


            var cart = new Cart(processor);

            var item1 = new Item('B', 15);
            var item2 = new Item('B', 15);
            var item3 = new Item('B', 15);

            // act
            cart.AddToCart(item1);
            cart.AddToCart(item2);
            cart.AddToCart(item3);

            // assert
            Assert.Equal(40, cart.Total);
        }

        [Fact]
        public void DiscountAppliedToOnly3ItemsWhen4Added()
        {
            List<IPromotion> promotions = new List<IPromotion> { new ThreeForFortyPromo() };
            var processor = new PromotionsProcessor(promotions);


            var cart = new Cart(processor);

            var item1 = new Item('B', 15);
            var item2 = new Item('B', 15);
            var item3 = new Item('B', 15);
            var item4 = new Item('B', 15);
            // act
            cart.AddToCart(item1);
            cart.AddToCart(item2);
            cart.AddToCart(item3);
            cart.AddToCart(item4);

            // assert
            Assert.Equal(55, cart.Total);
        }

        [Fact]
        public void DiscountAppliedToSix()
        {
            List<IPromotion> promotions = new List<IPromotion> { new ThreeForFortyPromo() };
            var processor = new PromotionsProcessor(promotions);


            var cart = new Cart(processor);

            var item1 = new Item('B', 15);
            var item2 = new Item('B', 15);
            var item3 = new Item('B', 15);
            var item4 = new Item('B', 15);
            var item5 = new Item('B', 15);
            var item6 = new Item('B', 15);
            // act
            cart.AddToCart(item1);
            cart.AddToCart(item2);
            cart.AddToCart(item3);
            cart.AddToCart(item4);
            cart.AddToCart(item5);
            cart.AddToCart(item6);

            // assert
            Assert.Equal(80, cart.Total);
        }
    }
}
