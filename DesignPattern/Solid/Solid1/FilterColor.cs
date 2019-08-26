namespace Solid1
{
    public class FilterColor : IFilterKind<BaseObject>
    {
        private readonly Color _color;

        public FilterColor(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(BaseObject t)
        {
            return t.Color == _color;
        }
    }
}
