using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Biz
{
    public class Cart
    {
        public List<Item> CartItems { get; private set; } = new List<Item>();

        public void AddToCart(Item item)
        {
            CartItems.Add(item);
        }
    }
}
