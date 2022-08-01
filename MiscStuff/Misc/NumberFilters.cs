
namespace Misc;


//public delegate bool FilterPredicate(int x);
public class NumberFilters
{

    public List<int> FilterOutEvens(List<int> numbers)
    {
        // anonymous function.

        //return Filter(numbers, delegate (int x)
        //{
        //    return x % 2 == 0;
        //});
        return Filter(numbers, x => x % 2 != 0);

    }

    public List<int> FilterOutOdds(List<int> numbers)
    {

        //return Filter(numbers, delegate (int x)
        //{

        //    return x % 2 != 0;
        //});
        return Filter(numbers, x => x % 2 == 0);
    }

    private List<int> Filter(List<int> numbers, Predicate<int> comparer)
    {
        var results = new List<int>();
        foreach (var num in numbers)
        {
            if (comparer(num))
            {
                results.Add(num);
            }
        }
        return results;
    }

    //private bool IsEven(int num)
    //{
    //    return num % 2 == 0;
    //}

    //private bool IsOdd(int num)
    //{
    //    return num % 2 != 0;
    //}
}
