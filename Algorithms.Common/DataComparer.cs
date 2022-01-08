namespace Algorithms.DataComparer;

public interface IDataComparer<T>
{
    CompareResult Compare(T item1, T item2);
}
    
public enum CompareType
{
    Equal = 1,
    Less = 0,
    More = -1
}
    
public struct CompareResult
{
    CompareType _kind;

    public CompareResult(CompareType kind)
    {
        _kind = kind;
    }

    public bool IsEqual => _kind == CompareType.Equal;
    public bool IsFirstLess => _kind == CompareType.Less;
    public bool IsFirstMore => _kind == CompareType.More;
}
    
public class IntComparer : IDataComparer<int>
{
    public CompareResult Compare(int item1, int item2)
    {
        CompareType kind = CompareType.Equal;
        if (item1 == item2) kind = CompareType.Equal;
        if (item1 < item2) kind = CompareType.Less;
        if (item1 > item2) kind = CompareType.More;
        return new CompareResult(kind);
    }
}
    
public static class DataComparers
{
    public static IDataComparer<int> Int = new IntComparer();

    public static IDataComparer<T> ByType<T>()
    {
        if (typeof(T) == typeof(int))
        {
            return Int as IDataComparer<T>;
        }
        return null;
    }

    public static IDataComparer<T> NewByType<T>()
    {
        if (typeof(T) == typeof(int))
        {
            return new IntComparer() as IDataComparer<T>;
        }
        return null;
    }
}