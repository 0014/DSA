/* * LeetCode Problem: https://leetcode.com/problems/maximum-erasure-value/
 * Difficulty: Medium
 * Tags: Hash Table, Sliding Window
 * Description: Given an integer array nums, return the maximum sum of a subarray that contains all unique elements.
 * A subarray is a contiguous non-empty sequence of elements within an array.
 */
namespace DSA.Solutions.Hashing.P1695_MaximumErasureValue
{
    public class Solution
    {
        public int MaximumUniqueSubarray(int[] nums)
        {
            var freq = new Dictionary<int, int>();

            var left = 0;
            var ans = 0;
            var curr = 0;
            for (var right = 0; right < nums.Length; right++)
            {

                while (freq.ContainsKey(nums[right]) && left < right)
                {
                    curr -= nums[left];
                    freq[nums[left]]--;
                    left++;
                }
                curr += nums[right];
                freq[nums[right]] = freq.GetValueOrDefault(nums[right], 0) + 1;
                ans = Math.Max(ans, curr);
            }

            return ans;
        }
    }
}
