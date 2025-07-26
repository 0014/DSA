/* * LeetCode Problem 1480: Running Sum of 1d Array
 * 
 * Given an array nums. We define a running sum of an array as runningSum[i] = 
 * sum(nums[0] + nums[1] + ... + nums[i]).
 * 
 * Return the running sum of nums.
 * 
 * Example:
 * Input: nums = [1,2,3,4]
 * Output: [1,3,6,10]
 */

namespace DSA.Solutions.ArraysAndStrings.P1480_RunningSumOf1dArray
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            var prefix = new int[nums.Length];
            prefix[0] = nums[0];

            for (var i = 1; i < nums.Length; i++)
                prefix[i] = nums[i] + prefix[i - 1];

            return prefix;
        }
    }
}
