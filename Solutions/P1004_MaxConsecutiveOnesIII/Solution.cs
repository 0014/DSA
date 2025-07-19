namespace DSA.Solutions.P1004_MaxConsecutiveOnesIII
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
