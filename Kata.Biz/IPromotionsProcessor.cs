using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Biz
{
    public interface IPromotionsProcessor
    {
        void ApplyPromotions(List<Item> items, Action<decimal> applyCallBack);
    }
}
