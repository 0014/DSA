/* You are given an array nums consisting of positive integers.
 * Return the total frequencies of elements in nums such that those elements all have the maximum frequency.
 * The frequency of an element is the number of occurrences of that element in the array.
*/
namespace DSA.Solutions.Hashing.P3005_CountElementsWithMaximumFrequency
{
    public class Solution
    {
        public int MaxFrequencyElements(int[] nums)
        {
            var dic = new Dictionary<int, int>();

            var max = 0;
            var ans = 0;
            foreach (var n in nums)
            {
                if (dic.ContainsKey(n))
                    dic[n]++;
                else
                    dic.Add(n, 1);

                if (max == dic[n]) ans += max;
                else if (dic[n] > max)
                {
                    max = dic[n];
                    ans = max;
                }
            }
            return ans;
        }
    }
}
