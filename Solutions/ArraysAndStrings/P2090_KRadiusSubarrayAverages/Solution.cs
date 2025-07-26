/*
 * LeetCode Problem: https://leetcode.com/problems/k-radius-subarray-averages/
 * Difficulty: Medium
 * Tags: Array, Prefix Sum
 * Description:
 * You are given a 0-indexed array nums of n integers and an integer k.
 * The k-radius average for a subarray of nums centered at index i with a radius k is defined as the average of all elements in nums between indices i - k and i + k (inclusive). If there are fewer than k elements before or after the index i, then the k-radius average is -1.
 * Return an array ans of length n where ans[i] is the k-radius average for the subarray centered at index i.
 */
namespace DSA.Solutions.ArraysAndStrings.P2090_KRadiusSubarrayAverages
{
    public class Solution
    {
        public int[] GetAverages(int[] nums, int k)
        {
            var n = nums.Length;
            var prefix = new double[n];
            prefix[0] = nums[0];
            for (var i = 1; i < prefix.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
            }

            var ans = new int[n];
            for (var i = 0; i < n; i++)
            {
                if (i < k || i > n - k - 1) ans[i] = -1;
                else ans[i] = (int)((prefix[i + k] - prefix[i - k] + nums[i - k]) / (2 * k + 1));
            }

            return ans;
        }
    }
}
