using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Biz
{
    public interface IPromotion
    {
        decimal Apply(ReadOnlyCollection<Item> items);
    }
}
