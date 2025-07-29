/* * LeetCode Problem: https://leetcode.com/problems/sum-of-unique-elements/
 * 
 * Given an integer array nums, return the sum of all unique elements in nums.
 * 
 * Example:
 * Input: nums = [1,2,3,2]
 * Output: 4
 * Explanation: The unique elements are 1 and 3, and their sum is 4.
 */
namespace DSA.Solutions.Hashing.P1748_SumOfUniqueElements
{
    public class Solution
    {
        public int SumOfUnique(int[] nums)
        {
            var dic = new Dictionary<int, int>();

            foreach (var n in nums)
            {
                dic[n] = dic.GetValueOrDefault(n, 0) + 1;
            }

            var ans = 0;
            foreach (var kvp in dic)
            {
                if (kvp.Value == 1) ans += kvp.Value;
            }
            return ans;
        }
    }
}
