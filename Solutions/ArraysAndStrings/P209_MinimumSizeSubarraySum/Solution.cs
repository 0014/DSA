/*
 * LeetCode Problem 209: Minimum Size Subarray Sum
 * https://leetcode.com/problems/minimum-size-subarray-sum/
 * This solution uses a sliding window approach to find the minimum length of a contiguous subarray
 * that has a sum greater than or equal to a given target.
 */
namespace DSA.Solutions.ArraysAndStrings.P209_MinimumSizeSubarraySum
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var ans = 100001;
            var curr = 0;

            int l = 0;
            for (var r = 0; r < nums.Length; r++)
            {
                curr += nums[r];
                while (l <= r && curr >= target)
                {
                    ans = Math.Min(ans, r - l + 1);
                    curr -= nums[l]; l++;
                }

            }
            return ans == 100001 ? 0 : ans;
        }
    }
}
