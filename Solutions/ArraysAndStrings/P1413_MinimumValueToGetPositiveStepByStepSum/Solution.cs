/* *
 * LeetCode Problem: https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
 * Given an array of integers nums, you start with an initial positive value startValue.
 * In each iteration, you calculate the step by step sum of startValue plus elements in nums (from left to right).
 * Return the minimum positive value of startValue such that the step by step sum is never less than 1.
*/

namespace DSA.Solutions.ArraysAndStrings.P1413_MinimumValueToGetPositiveStepByStepSum
{
    public class Solution
    {
        public int MinStartValue(int[] nums)
        {
            var min = nums[0];
            var prefix = new int[nums.Length];
            prefix[0] = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
                min = Math.Min(min, prefix[i]);
            }

            return 1 - min < 1 ? 1 : 1 - min;
        }
    }
}
