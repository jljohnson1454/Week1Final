
namespace Misc;

public class FilteringNumbers
{

    [Fact]
    public void CanFilterOutEvens()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var filter = new NumberFilters();
        // Magic!

        var evens = filter.FilterOutEvens(numbers);

        Assert.Equal(1, evens[0]);
        Assert.Equal(3, evens[1]);
        Assert.Equal(5, evens[2]);
        Assert.Equal(7, evens[3]);
        Assert.Equal(9, evens[4]);



    }

    [Fact]
    public void CanFilterOutOdds()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var filter = new NumberFilters();
        // Magic!

        var evens = filter.FilterOutOdds(numbers);

        Assert.Equal(2, evens[0]);
        Assert.Equal(4, evens[1]);
        Assert.Equal(6, evens[2]);
        Assert.Equal(8, evens[3]);
        
    }
}
