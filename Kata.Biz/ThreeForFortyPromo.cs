
using System.Collections.ObjectModel;

namespace Kata.Biz
{
    public class ThreeForFortyPromo : IPromotion
    {
        public decimal Apply(ReadOnlyCollection<Item> items)
        {
            var itemsForDiscount = items.Where(items => items.SKU == 'B');
            int numberOfItems = itemsForDiscount.Count() / 3;

            decimal totalDiscount = 0M;
            if (numberOfItems > 0)
            {
                totalDiscount = itemsForDiscount
                    .Take(numberOfItems * 3)
                    .Select(item => item.UnitPrice)
                    .Sum() - (40 * numberOfItems);
            }
            return totalDiscount;
        }
    }
}
