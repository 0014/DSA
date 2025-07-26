/* * LeetCode Problem 1004: Max Consecutive Ones III
 * https://leetcode.com/problems/max-consecutive-ones-iii/
 *
 * Given a binary array nums and an integer k, return the maximum number of consecutive 1's in the array if you can flip at most k 0's.
 */

namespace DSA.Solutions.ArraysAndStrings.P1004_MaxConsecutiveOnesIII
{
    public class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
            var result = 0;
            var zeroes = 0;
            var left = 0;
            for (var right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0) zeroes++;

                while (zeroes > k)
                {
                    if (nums[left] == 0) zeroes--;
                    left++;
                }

                result = Math.Max(result, right - left + 1);
            }

            return result;
        }
    }
}
