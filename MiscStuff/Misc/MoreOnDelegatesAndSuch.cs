
namespace Misc;

public class MoreOnDelegatesAndSuch
{

    [Fact]
    public void ActionTypes()
    {
        Action x;

        x = () => Console.WriteLine("Hello!");

        x();

        x = () => Console.WriteLine("Done!");

        x();

        Action<string> y;
        y = (message) => Console.WriteLine(message);

        y("Say Hello");

        Action<int, int, string, Employee> doIt;
        // doIt = (x,y,z,e) => 

    }

    [Fact]
    public void FuncTypes()
    {
        Func<string, string, int> countLetters;

        countLetters = (first, last) => $"{last}, {first}".Length;

        Assert.Equal(9, countLetters("Solo", "Han"));

        var calculator = new Dictionary<char, Func<int, int, int>>  {
            {  '+',  (a,b) => a + b },
            { '-', (a,b) => a - b },
            { '*', (a,b) => a * b }
        };

        Assert.Equal(9, calculator['*'](3, 3));
    }

    [Fact]
    public void ExtensionMethods()
    {
        var isOdd = (int x) => x % 2 != 0;


        //Assert.True(5.IsOdd());

        //Assert.False(6.isOdd());

        Assert.True(5.IsOdd());
        Assert.True(6.IsEven());


    }

    [Fact]
    public void IntroToLinq()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var evens = numbers.Where(n => n.IsEven());

    }
}


public static class Utils
{
    public static bool IsOdd(this int x) => x % 2 != 0;
    
    public static bool IsEven(this int x)
    {
        return x % 2 == 0;
    }
}