


using h = Misc.Hr;
using p = Misc.Purchasing;

namespace Misc;

public class BasicTests
{

    [Fact]
    public void WorkingWithVendors()
    {
       h.Vendor v = new h.Vendor();

        p.Vendor x = new p.Vendor();
    }

    [Fact]
    public void CanAddTwoNumbers()
    {
        // Given (Arrange)
        int a = 10, b = 20, answer;
        // When (Act)
        answer = a + b; // "System Under Test" (SUT)
        // Then (Assert)
        Assert.Equal(30, answer);
    }

    [Theory]
    [InlineData(2,2,4)]
    [InlineData(3,3,6)]
    [InlineData(10,12,22)]
    public void AddingTwoNumber(int a, int b, int expected)
    {
        int answer = a + b;

        Assert.Equal(expected, answer);
    }
   
}




