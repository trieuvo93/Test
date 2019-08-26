using System.Collections.Generic;

namespace Solid1
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, IFilterKind<T> type);
    }
}
