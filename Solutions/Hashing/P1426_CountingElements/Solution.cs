/*
 * LeetCode Problem: 1426. Counting Elements
 * Problem Link: https://leetcode.com/problems/counting-elements/
 * Description:
 * Given an integer array arr, count how many elements x there are, such that x + 1 is also in arr.
 * If there are duplicates in arr, count them separately.
 * Example:
 * Input: arr = [1,2,3]
 * Output: 2
 * Explanation: 1 and 2 are counted because 2 and 3 are in arr.
 */
namespace DSA.Solutions.Hashing.P1426_CountingElements
{
    public class Solution
    {
        public int CountElements(int[] arr)
        {

            var dic = new Dictionary<int, int>();
            foreach (var n in arr)
            {
                if (dic.ContainsKey(n)) dic[n]++;
                else dic.Add(n, 1);
            }

            var ans = 0;
            foreach (var kvp in dic)
                if (dic.ContainsKey(kvp.Key + 1)) ans += kvp.Value;

            return ans;
        }
    }
}
