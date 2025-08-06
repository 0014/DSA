/* Problem Statement: https://leetcode.com/problems/length-of-longest-subarray-with-at-most-k-frequency/
 * You are given an integer array nums and an integer k.
 * The frequency of an element x is the number of times it occurs in an array.
 * An array is called good if the frequency of each element in this array is less than or equal to k.
 * Return the length of the longest good subarray of nums.
 * A subarray is a contiguous non-empty sequence of elements within an array.
 */
namespace DSA.Solutions.Hashing.P2958_LengthOfLongestSubarrayWithAtMostKFrequency
{
    public class Solution
    {
        public int MaxSubarrayLength(int[] nums, int k)
        {
            var ans = 0;
            var freq = new Dictionary<int, int>();
            var left = 0;
            for (var right = 0; right < nums.Length; right++)
            {
                freq[nums[right]] = freq.GetValueOrDefault(nums[right], 0) + 1;

                while (freq[nums[right]] > k && left < right)
                {
                    freq[nums[left]]--;
                    left++;
                }
                ans = Math.Max(ans, right - left + 1);
            }
            return ans;
        }
    }
}
