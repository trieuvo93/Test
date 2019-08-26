namespace Solid
{
    public class FilterColor : IFilterKind<Product>
    {
        private readonly Color _color;

        public FilterColor(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == _color;
        }
    }
}
