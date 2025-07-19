
namespace DSA.Solutions.P1480_RunningSumOf1dArray
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
