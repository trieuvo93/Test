using System.Collections.Generic;

namespace Solid
{
    public class FilterProductByColor : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, IFilterKind<Product> kind)
        {
            foreach (var product in items)
            {
                if (kind.IsSatisfied(product))
                {
                    yield return product;
                }
            }
        }
    }
}
