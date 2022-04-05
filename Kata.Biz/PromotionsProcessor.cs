
namespace Kata.Biz
{
    public class PromotionsProcessor : IPromotionsProcessor
    {
        private readonly List<IPromotion> _promotions;

        public PromotionsProcessor(List<IPromotion> promotions)
        {
            this._promotions = promotions;
        }

        public void ApplyPromotions(List<Item> items, Action<decimal> applyCallBack)
        {
            foreach (IPromotion promotion in _promotions)
            {
                decimal discountAmount = promotion.Apply(items);
                applyCallBack(discountAmount);
            }
        }
    }
}
