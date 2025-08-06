/* * LeetCode Problem 791: Custom Sort String
 * https://leetcode.com/problems/custom-sort-string/
 *
 * This solution implements a custom sorting algorithm based on the order of characters specified in the 'order' string.
 * It counts the frequency of each character in the string 's' and constructs the result string accordingly.
 */

using System.Text;
namespace DSA.Solutions.Hashing.P0791_CustomSortString
{
    public class Solution
    {
        public string CustomSortString(string order, string s)
        {
            var freq = new int[26];
            foreach (var c in s) freq[c - 'a']++;

            var sb = new StringBuilder();
            foreach (var c in order)
            {
                for (var i = 0; i < freq[c - 'a']; i++) sb.Append(c);
                freq[c - 'a'] = 0;
            }

            for (var i = 0; i < freq.Length; i++)
            {
                for (var j = 0; j < freq[i]; j++) sb.Append((char)('a' + i));
            }

            return sb.ToString();
        }
    }
}
