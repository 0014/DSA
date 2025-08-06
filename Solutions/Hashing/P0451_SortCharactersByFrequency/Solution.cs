/* LeetCode Problem 451: Sort Characters By Frequency
 * https://leetcode.com/problems/sort-characters-by-frequency/
 *
 * Given a string s, sort it in decreasing order based on the frequency of the characters. The frequency of a character is the number of times it appears in the string.
 * Return the sorted string. If there are multiple answers, return any of them.
 */
using System.Text;

namespace DSA.Solutions.Hashing.P0451_SortCharactersByFrequency
{
    public class Solution
    {
        public string FrequencySort(string s)
        {
            var freq = new Dictionary<char, int>();

            foreach (var c in s)
                freq[c] = freq.GetValueOrDefault(c, 0) + 1;

            freq = freq.OrderByDescending(x => x.Value).ToDictionary();

            var sb = new StringBuilder();
            foreach (var kvp in freq)
            {
                for (var i = 0; i < kvp.Value; i++)
                    sb.Append(kvp.Key);
            }
            return sb.ToString();
        }
    }
}
