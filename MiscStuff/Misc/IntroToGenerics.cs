
namespace Misc;

public class IntroToGenerics
{
    [Fact]
    public void UsingAMethodNonGenericMethod()
    {
        int x = 10;
        var m = new MathTools();

        Assert.Equal(11, m.Increment(x));

        Assert.Equal(42.20M, m.Increment(41.20M));

        int a = 10, b = 20;

        m.Swap<int>(ref a, ref b);

        Assert.Equal(20, a);
        Assert.Equal(10, b);

        string p1 = "Sue", p2 = "Joe";

        m.Swap<string>(ref p1, ref p2);

        Assert.Equal("Joe", p1);
        Assert.Equal("Sue", p2);

    }

    [Fact]
    public void UsingAGenericClass()
    {
        var r1 = new ApiCollectionResponse<Employee>();
        r1.Data.Add(new Employee());

        //var r2 = new ApiCollectionResponse<Song>();
        //r2.Data.Add(new Song("whpit", "Devo"));

        var r2 = new ApiCollectionResponse<PartTimeEmployee>();

        
    }
}


public class MathTools
{

    public void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
    public int Increment(int x)
    {
        return x += 1;
    }
    public decimal Increment(decimal x)
    {
        return x += 1;
    }
}

// GET /employees
public class ApiCollectionResponse<T> where T: Employee, new()
{
    public List<T> Data { get; set; } = new();
}


public class Employee { }

public class FullTimeEmployee : Employee { }
public class PartTimeEmployee : Employee { }