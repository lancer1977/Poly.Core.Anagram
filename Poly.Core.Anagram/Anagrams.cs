

namespace PolyhydraGames.Core.Anagram
{
    public static class Anagrams
    {
        public static bool IsPartialAnagram(this string rawSource, string rawProposed)
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
        public static bool IsAnagram(this string rawSource, string rawProposed)
        {
            if (string.IsNullOrEmpty(rawSource) || string.IsNullOrEmpty(rawProposed)) return false;
            if(rawSource.Length != rawProposed.Length) return false;

            var sourceChars = rawSource.ToLower().Trim().ToList().Order().ToList();
            var proposedChars = rawProposed.ToLower().Trim().ToList().Order().ToList();
            for (var x = 0; x < rawSource.Length; x++)
            {
                if (sourceChars[x] != proposedChars[x]) return false;
            }
            
            return true;
        }

    }
}
