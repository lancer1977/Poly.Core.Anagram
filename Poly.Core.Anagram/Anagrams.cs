

namespace PolyhydraGames.Core.Anagram
{
    public static class Anagrams
    {
        public static bool IsAnagram(this string rawSource, string rawProposed)
        {

            var source = rawSource.ToLower().Trim();
            var proposed = rawProposed.ToLower().Trim();
            List<char> sourceChars = source.ToList();
            foreach (var ltr in proposed)
            {
                var index = sourceChars.IndexOf(ltr);
                if (index == -1) return false;
                sourceChars.RemoveAt(index);
            }

            return true;
        }
 

    }
}
