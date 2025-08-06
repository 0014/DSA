/* Given an array of integers nums, return the number of good pairs.
 * A pair (i, j) is called good if nums[i] == nums[j] and i < j.
 */
namespace DSA.Solutions.Hashing.P1512_NumberOfGoodPairs
{
    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var freq = new Dictionary<int, int>();
            foreach (var n in nums)
                freq[n] = freq.GetValueOrDefault(n, 0) + 1;

            var ans = 0;
            foreach (var kvp in freq)
                ans += (kvp.Value - 1) * kvp.Value / 2;
            return ans;
        }
    }
}
