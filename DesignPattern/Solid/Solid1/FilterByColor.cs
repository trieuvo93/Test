using System.Collections.Generic;

namespace Solid1
{
    public class FilterByColor : IFilter<BaseObject>
    {
        public IEnumerable<BaseObject> Filter(IEnumerable<BaseObject> items, IFilterKind<BaseObject> type)
        {
            foreach (var product in items)
            {
                if (type.IsSatisfied(product))
                {
                    yield return product;
                }
            }
        }
    }
}
