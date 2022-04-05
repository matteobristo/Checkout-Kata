// See https://aka.ms/new-console-template for more information
using Kata.Biz;

Console.WriteLine("TEST -- KATA CART --");

var cart = new Cart(new PromotionsProcessor(new List<IPromotion>() { new TwentyFivePercentPromo(), new ThreeForFortyPromo() }));

cart.AddToCart(new Item('A', 10));
cart.AddToCart(new Item('B', 15));
cart.AddToCart(new Item('B', 15));
cart.AddToCart(new Item('B', 15));
cart.AddToCart(new Item('B', 15));
cart.AddToCart(new Item('C', 40));
cart.AddToCart(new Item('D', 55));
cart.AddToCart(new Item('D', 55));

Console.WriteLine($"Total To Pay: £{cart.Total}");
Console.ReadLine();
