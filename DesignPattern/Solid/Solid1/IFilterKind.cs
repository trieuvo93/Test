namespace Solid1
{
    public interface IFilterKind<T>
    {
        bool IsSatisfied(T t);
    }
}
