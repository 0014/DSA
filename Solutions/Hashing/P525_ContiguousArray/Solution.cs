/*
 * LeetCode Problem 525: Contiguous Array
 * https://leetcode.com/problems/contiguous-array/
 *
 * This problem requires finding the maximum length of a contiguous subarray with an equal number of 0s and 1s.
 */
namespace DSA.Solutions.Hashing.P525_ContiguousArray
{
    public class Solution
    {
        public int FindMaxLength(int[] nums)
        {
            var counts = new int[2];

            var l = 0;
            var max = 0;
            for (var r = 0; r < nums.Length; r++)
            {
                counts[r]++;
                while (l < r && counts[0] != counts[1])
                {
                    counts[l]--;
                    l++;
                }
                max = Math.Max(max, r - l + 1);
            }

            return max;
        }
    }
}
