namespace PolyhydraGames.Core.Anagram.Test;

[TestFixture]
public class TestBase
{


    [TestCase("butter"),
     TestCase("fly"),
     TestCase("butt"),
     TestCase("flutter"),
    ]
    public void ButterflyAnagrams(string proposal)
    {
        Assert.That("butterfly".IsAnagram(proposal));


    }
}
