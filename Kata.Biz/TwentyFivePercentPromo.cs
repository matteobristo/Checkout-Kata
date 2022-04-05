
namespace Kata.Biz
{
    public class TwentyFivePercentPromo : IPromotion
    {
        public decimal Apply(List<Item> items)
        {
            var itemsForDiscount = items.Where(items => items.SKU == 'D');
            int numberOfItems = itemsForDiscount.Count() / 2;

            decimal totalDiscount = 0M;
            if (numberOfItems > 0)
            {
                var originalVal = itemsForDiscount
                    .Take(numberOfItems * 2)
                    .Select(item => item.UnitPrice).Sum();
                totalDiscount = originalVal * 25 / 100;

            }
            return totalDiscount;
        }
    }
}
