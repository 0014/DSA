namespace DSA.Solutions.P209_MinimumSizeSubarraySum
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var ans = 100001;
            var curr = 0;

            int l = 0;
            for (var r = 0; r < nums.Length; r++)
            {
                curr += nums[r];
                while (l <= r && curr >= target)
                {
                    ans = Math.Min(ans, r - l + 1);
                    curr -= nums[l]; l++;
                }

            }
            return ans == 100001 ? 0 : ans;
        }
    }
}
