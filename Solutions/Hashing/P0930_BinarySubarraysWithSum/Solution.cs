/* Given a binary array nums and an integer goal, return the number of non-empty subarrays with a sum goal.
 * A subarray is a contiguous part of the array.
 */
namespace DSA.Solutions.Hashing.P0930_BinarySubarraysWithSum
{
    public class Solution
    {
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            var dic = new Dictionary<int, int>() { { 0, 1 } };

            int curr = 0, ans = 0;
            foreach (var n in nums)
            {
                curr += n;
                if (dic.ContainsKey(curr - goal)) ans += dic[curr - goal];
                dic[curr] = dic.GetValueOrDefault(curr, 0) + 1;
            }

            return ans;
        }
    }
}
