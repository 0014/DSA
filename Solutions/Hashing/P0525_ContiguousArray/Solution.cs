/*
 * LeetCode Problem 525: Contiguous Array
 * https://leetcode.com/problems/contiguous-array/
 *
 * This problem requires finding the maximum length of a contiguous subarray with an equal number of 0s and 1s.
 */
namespace DSA.Solutions.Hashing.P0525_ContiguousArray
{
    public class Solution
    {
        public int FindMaxLength(int[] nums)
        {
            var dic = new Dictionary<int, int> { { 0, 0 } };

            int counter = 0, ans = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var add = nums[i] == 1 ? 1 : -1;
                counter += add;

                if (!dic.ContainsKey(counter)) dic.Add(counter, i + 1);
                else ans = Math.Max(ans, i - dic[counter] + 1);
            }

            return ans;
        }
    }
}
