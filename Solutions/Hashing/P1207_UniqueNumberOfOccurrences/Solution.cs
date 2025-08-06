/* Problem: https://leetcode.com/problems/unique-number-of-occurrences/
 * Difficulty: Easy
 * Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.
 */
namespace DSA.Solutions.Hashing.P1207_UniqueNumberOfOccurrences
{
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var freq = new Dictionary<int, int>();
            foreach (var n in arr)
                freq[n] = freq.GetValueOrDefault(n, 0) + 1;

            var set = new HashSet<int>();
            foreach (var kvp in freq)
            {
                if (set.Contains(kvp.Value)) return false;
                set.Add(kvp.Value);
            }
            return true;
        }
    }
}
