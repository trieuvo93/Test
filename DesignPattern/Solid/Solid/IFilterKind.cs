namespace Solid
{
    public interface IFilterKind<T>
    {
        bool IsSatisfied(T product);
    }
}
