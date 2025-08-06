/* * LeetCode Problem: 1657. Determine if Two Strings Are Close
 * Difficulty: Medium
 * Link: https://leetcode.com/problems/determine-if-two-strings-are-close/
 * Description: Two strings are considered close if you can attain one from the other using the following operations:
 * 1. Swap any two existing characters.
 * 2. Transform every occurrence of one character into another character, and do the same with the other character.
 * Example: "abc" and "bca" are close because you can swap 'a' and 'b' to get "bac", then swap 'b' and 'c' to get "cba".
 */

namespace DSA.Solutions.Hashing.P1657_DetermineIfTwoStringsAreClose
{
    public class Solution
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            var set = new HashSet<char>();
            foreach (var c in word1) set.Add(c);
            foreach (var c in word2) if (!set.Contains(c)) return false;

            var freq1 = new int[26];
            foreach (var c in word1) freq1[c - 'a']++;

            var freq2 = new int[26];
            foreach (var c in word2) freq2[c - 'a']++;

            Array.Sort(freq1);
            Array.Sort(freq2);
            for (var i = 0; i < 26; i++)
            {
                if (freq1[i] != freq2[i]) return false;
            }
            return true;
        }
    }
}
