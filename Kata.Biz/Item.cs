using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Biz
{
    public class Item
    {
        public char SKU { get; private set; }
        public decimal UnitPrice { get; private set; }

        public Item(char sku, decimal price)
        {
            this.SKU = sku;
            this.UnitPrice = price;
        }
    }
}
