/*
 * Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
 * Example 1:
    Input: nums = [3,0,1]
    Output: 2
    Explanation:
    n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.
 */
namespace DSA.Solutions.Hashing.P0206_MissingNumber
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            var set = new HashSet<int>();
            for (var i = 0; i < nums.Length; i++) set.Add(nums[i]);

            for (var i = 0; i <= nums.Length; i++) if (!set.Contains(i)) return i;

            return nums.Length + 1;

        }
    }
}
