/*
 * LeetCode Problem 771: Jewels and Stones
 * https://leetcode.com/problems/jewels-and-stones/
 * You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
 * Letters are case sensitive, so "a" is considered a different type of stone from "A".
 */

namespace DSA.Solutions.Hashing.P771_JewelsAndStones
{
    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var set = new HashSet<char>();
            foreach (var c in jewels) set.Add(c);

            var ans = 0;
            foreach (var c in stones) if (set.Contains(c)) ans++;
            return ans;
        }
    }
}
