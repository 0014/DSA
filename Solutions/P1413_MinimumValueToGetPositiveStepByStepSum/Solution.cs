namespace DSA.Solutions.P1413_MinimumValueToGetPositiveStepByStepSum
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

            return (1 - min) < 1 ? 1 : 1 - min;
        }
    }
}
