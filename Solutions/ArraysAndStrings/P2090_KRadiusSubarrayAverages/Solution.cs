namespace DSA.Solutions.ArraysAndStrings.P2090_KRadiusSubarrayAverages
{
    public class Solution
    {
        public int[] GetAverages(int[] nums, int k)
        {
            var n = nums.Length;
            var prefix = new double[n];
            prefix[0] = nums[0];
            for (var i = 1; i < prefix.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
            }

            var ans = new int[n];
            for (var i = 0; i < n; i++)
            {
                if (i < k || i > n - k - 1) ans[i] = -1;
                else ans[i] = (int)((prefix[i + k] - prefix[i - k] + nums[i - k]) / (2 * k + 1));
            }

            return ans;
        }
    }
}
