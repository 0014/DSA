/*
 * LeetCode Problem: 1732. Find the Highest Altitude
 * Problem Link: https://leetcode.com/problems/find-the-highest-altitude/
 * Description:
 * There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude 0.
 * You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i and i + 1 for all (0 <= i < n). Return the highest altitude of a point.
 */

namespace DSA.Solutions.ArraysAndStrings.P1732_FindTheHighestAltitude
{
    public class Solution
    {
        public int LargestAltitude(int[] gain)
        {
            var ans = 0;
            var curr = 0;
            for (var i = 0; i < gain.Length; i++)
            {
                curr += i;
                ans = Math.Max(ans, curr);
            }
            return ans;
        }
    }
}
