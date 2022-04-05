using System.Collections.ObjectModel;


namespace Kata.Biz
{
    public interface IPromotionsProcessor
    {
        void ApplyPromotions(ReadOnlyCollection<Item> items, Action<decimal> applyCallBack);
    }
}
