namespace PolyhydraGames.Core.Anagram.Test;

[TestFixture]
public class PartialAnagramTests
{


    [TestCase("butter"),
     TestCase("fly"),
     TestCase("butt"),
     TestCase("flutter"),
    ]
    public void ButterflyAnagrams(string proposal)
    {
        Assert.That("butterfly".IsPartialAnagram(proposal));

    }



    [TestCase("butterer"),
     TestCase("flying"),
    ]
    public void ButterflyAnagramsNegatives(string proposal)
    {
        Assert.That(!"butterfly".IsPartialAnagram(proposal));


    }
}

public class AnagramTests
{
    [TestCase("seats", "asset")]
    public void Anagrams(string source, string proposal)
    {
        Assert.That(source.IsAnagram(proposal));
    }
    [TestCase("seats", "ass")]
    public void NegativeAnagrams(string source, string proposal)
    {
        Assert.That(!source.IsAnagram(proposal));
    }
    
    [
        TestCase("roost"),
    ]
    public void SendAnagrams(string proposal)
    {
        Assert.That("roots".IsAnagram(proposal));


    }
}
