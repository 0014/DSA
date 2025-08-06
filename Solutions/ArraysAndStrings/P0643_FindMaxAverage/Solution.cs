/*
 * LeetCode 643. Maximum Average Subarray I
 * https://leetcode.com/problems/maximum-average-subarray-i/
 *
 * Given an integer array nums and an integer k, return the maximum average value of a subarray of length k.
 * Any subarray of length k is a contiguous subarray of length k.
 */
public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var curr = 0d;
        for (var i = 0; i < k; i++)
            curr += nums[i];
        var max = curr;

        for (var i = 1; i <= nums.Length - k; i++)
        {
            curr -= nums[i - 1];
            curr += nums[i + k - 1];
            max = Math.Max(max, curr);
        }

        return max / k;
    }
}
