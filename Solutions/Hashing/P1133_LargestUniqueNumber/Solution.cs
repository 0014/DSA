/* * LeetCode Problem: 1133. Largest Unique Number
 * Difficulty: Easy
 * Link: https://leetcode.com/problems/largest-unique-number/
 * Given an integer array nums, return the largest integer that only occurs once. If no integer occurs once, return -1.
 */
namespace DSA.Solutions.Hashing.P1133_LargestUniqueNumber
{
    public class Solution
    {
        public int LargestUniqueNumber(int[] nums)
        {
            var set = new HashSet<int>();
            var once = new HashSet<int>();

            foreach (var num in nums)
            {
                if (set.Contains(num)) once.Remove(num);
                else
                {
                    set.Add(num);
                    once.Add(num);
                }
            }

            var max = -1;
            foreach (var num in once)
            {
                max = Math.Max(max, num);
            }

            return max;
        }
    }
}
