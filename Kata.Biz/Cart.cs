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
        public decimal Total { get; private set; } = 0M;

        public void AddToCart(Item item)
        {
            CartItems.Add(item);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            this.Total = 0;

            foreach (Item item in CartItems)
            {
                Total += item.UnitPrice;
            }
        }
    }
}
