/* 
 * LeetCode Problem 217: Contains Duplicate
 * https://leetcode.com/problems/contains-duplicate/
 * 
 * Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
 */
namespace DSA.Solutions.Hashing.P0217_ContainsDuplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();

            foreach (var i in nums)
            {
                if (set.Contains(i)) return true;
                set.Add(i);
            }

            return false;
        }
    }
}
