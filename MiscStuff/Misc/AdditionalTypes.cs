
namespace Misc;

public class AdditionalTypes
{
    
    [Fact]
    public void CanFormatName()
    {
        var info = FormatName("Han", "Solo");
        Assert.Equal("Solo, Han", info.name);
        Assert.Equal(9, info.length);
    }

    [Fact]
    public void FormattingWithATuple()
    {

        var result = FormatName2("Luke", "Skywalker");

        Assert.Equal("Skywalker, Luke", result.Item1);
        Assert.Equal(15, result.Item2);

        var (fn, len) = FormatName2("Luke", "Skywalker");

        Assert.Equal("Skywalker, Luke", fn);
        Assert.Equal(15, len);

        var (_, l) = FormatName2("Boba", "Fett");

        Assert.Equal(10, l);

    }


    public FormattedNameInfo FormatName(string first, string last)
    {
        string fullName = $"{last}, {first}";

        return new FormattedNameInfo(fullName, fullName.Length);
    }

    public (string, int) FormatName2(string first, string last)
    {
        string fullName = $"{last}, {first}";
        return (fullName, fullName.Length);
    }

}

public record FormattedNameInfo(string name, int length);


