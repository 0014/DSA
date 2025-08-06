/* * LeetCode Problem: https://leetcode.com/problems/find-lucky-integer-in-an-array/
 * 
 * Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.
 * Return the largest lucky integer in the array. If there is no lucky integer return -1.
 */
namespace DSA.Solutions.Hashing.P1394_FindLuckyIntegerInAnArray
{
    public class Solution
    {
        public int FindLucky(int[] arr)
        {
            var freq = new Dictionary<int, int>();
            foreach (var n in arr)
                freq[n] = freq.GetValueOrDefault(n, 0) + 1;

            var ans = -1;
            foreach (var kvp in freq)
                if (kvp.Key == kvp.Value) ans = Math.Max(ans, kvp.Key);

            return ans;
        }
    }
}
