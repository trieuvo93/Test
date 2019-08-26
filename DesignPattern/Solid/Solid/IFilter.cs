using System.Collections.Generic;

namespace Solid
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, IFilterKind<T> kind);
    }
}
