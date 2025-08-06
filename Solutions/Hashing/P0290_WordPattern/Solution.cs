/* * LeetCode Problem 290: Word Pattern
 * https://leetcode.com/problems/word-pattern/
 * 
 * This solution checks if a given pattern matches a string of words.
 * It uses a dictionary to map characters in the pattern to words in the string.
 */
namespace DSA.Solutions.Hashing.P0290_WordPattern
{
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            var map = new Dictionary<char, string>();
            var words = s.Split(' ');

            if (pattern.Length != words.Length) return false;

            for (var i = 0; i < pattern.Length; i++)
            {
                if (map.ContainsKey(pattern[i]))
                {
                    if (map[pattern[i]] != words[i]) return false;
                }
                else if (map.ContainsValue(words[i])) return false;
                else map.Add(pattern[i], words[i]);
            }

            return true;
        }
    }
}
