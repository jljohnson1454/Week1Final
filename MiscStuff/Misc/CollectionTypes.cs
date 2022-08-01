using System.Collections;
namespace Misc;

public class CollectionTypes
{
    [Fact]
    public void OldSkoolLists()
    {
        var favoriteNumbers = new ArrayList();
        favoriteNumbers.Add(10);
        favoriteNumbers.Add(12);
        favoriteNumbers.Add(42);

        Assert.Equal(3, favoriteNumbers.Count);
        Assert.Equal(10, favoriteNumbers[0]);

        favoriteNumbers[0] = 9;

        Assert.Equal(9, favoriteNumbers[0]);

        favoriteNumbers.Add("Tacos");

        //favoriteNumbers[0] = "Beer";
        var sum = ((int)favoriteNumbers[0]) + ((int)favoriteNumbers[1]);

        Assert.Equal(21, sum);
      
    }

    [Fact]
    public void FavoriteNumbersButTypeSafe()
    {
        var favoriteNumbers = new List<int>();

        favoriteNumbers.Add(9);
        favoriteNumbers.Add(12);
        //favoriteNumbers.Add("Tacos");

        var sum = favoriteNumbers[0] + favoriteNumbers[1];

        Assert.Equal(21, sum);
    }

    [Fact]
    public void InitializingAList()
    {
        var ingredients = new List<string> { "Eggs", "Cheese", "Milk" };

        Assert.Equal("Cheese", ingredients[1]);

        Assert.Throws<ArgumentOutOfRangeException>(() => ingredients[5]);

        if(ingredients.Contains("Eggs"))
        {

        }
    }

    [Fact]
    public void EnumeratingThings()
    {
        var ingredients = new List<string> { "Eggs", "Cheese", "Milk" };
        
        foreach(var ingredient in ingredients)
        {
            // ingredient
        }

        var story = "It was a dark and stormy night";

        var letters = 0;
        foreach(char c in story)
        {
            letters++;
        }

    }

    [Fact]
    public void Dictionaries()
    {
        var playlist = new Dictionary<string, Song>();
        playlist.Add("kiss", new Song("Kiss", "Prince"));
        playlist.Add("final", new Song("Final Countdown", "Europe"));

        Assert.Equal("Final Countdown", playlist["final"].Title);

        Assert.True(playlist.ContainsKey("kiss"));
        Assert.False(playlist.ContainsKey("dance"));

        //playlist.Add("kiss", new Song("Kiss", "Tom Jones"));
        playlist["kiss"] = new Song("Kiss", "Tom Jones");
    }

    [Fact]
    public void InitializingAndEnumeratingDictionaries()
    {
        var playlist = new Dictionary<string, Song>
        {
            { "kiss", new Song("Kiss", "Prince") },
            { "final", new Song("Final Countdown", "Europe") }
        };

        foreach(var key in playlist.Keys)
        {
            // "kiss", "final"
        }

        foreach(var value in playlist.Values)
        {
            // the song, the song.
        }

        foreach(var entry in playlist)
        {
            // key = "kiss", "final"
            
        }

    }

    [Fact]
    public void PartyPlanning()
    {
        var party = new PartyPlan();

        party.NameOfParty = "Done with week 1!";
      
        party.Playlist.Add("celebration", new Song("Celebration", "Kool and the Gang"));
    }
}

public record Song(string Title, string Artist);

public class PartyPlan
{
    public string NameOfParty { get; set; } = string.Empty;

    public Dictionary<string, Song> Playlist { get; set; } = new();
}