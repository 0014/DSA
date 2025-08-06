// Given a string s, find the length of the longest substring without duplicate characters.

namespace DSA.Solutions.Hashing.P0003_LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();

            var left = 0;
            var ans = 0;
            for (var right = 0; right < s.Length; right++)
            {
                while (left < right && set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[right]);
                ans = Math.Max(ans, right - left + 1);
            }

            return ans;
        }
    }
}
