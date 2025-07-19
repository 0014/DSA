public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var curr = 0d;
        for (var i = 0; i < k; i++)
            curr += nums[i];
        var max = curr;

        for (var i = 1; i <= nums.Length - k; i++)
        {
            curr -= nums[i - 1];
            curr += nums[i + k - 1];
            max = Math.Max(max, curr);
        }

        return max / k;
    }
}
