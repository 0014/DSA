/* 
 * LeetCode Problem 205: Isomorphic Strings
 * https://leetcode.com/problems/isomorphic-strings/
 * 
 * This solution checks if two strings are isomorphic by mapping characters from the first string to the second.
 * If a character in the first string has already been mapped to a different character in the second string,
 * the function returns false. Otherwise, it continues mapping until all characters are checked.
 */
namespace DSA.Solutions.Hashing.P0205_IsomorphicStrings
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var map = new Dictionary<char, char>();
            var reversemap = new Dictionary<char, char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    if (map[s[i]] != t[i]) return false;
                }
                else if (reversemap.ContainsKey(t[i]))
                {
                    if (reversemap[t[i]] != s[i]) return false;
                }
                else
                {
                    map.Add(s[i], t[i]);
                    reversemap.Add(t[i], s[i]);
                }
            }
            return true;
        }
    }
}
