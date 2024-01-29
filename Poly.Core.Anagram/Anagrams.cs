 

namespace PolyhydraGames.Core.Anagram
{
    public static class Anagrams
    {
        public static bool IsAnagram(this string rawSource, string rawProposed)
        {

            var source = rawSource.ToLower().Trim();
            var proposed = rawProposed.ToLower().Trim();
            foreach (var ltr in proposed)
            {
                var index = source.IndexOf(ltr);
                if (index == -1) return false;
                source.Remove(index);
            }

            return true;
        }

        
    }
}
