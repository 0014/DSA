/* * LeetCode Problem 2540: Minimum Common Value
 * 
 * Given two integer arrays nums1 and nums2, return the minimum common value that appears in both arrays.
 * If there is no common value, return -1.
 * 
 * Example:
 * Input: nums1 = [1,2,3], nums2 = [2,4]
 * Output: 2
 */
namespace DSA.Solutions.ArraysAndStrings.P2540_MinimumCommonValue
{
    public class Solution
    {
        public int GetCommon(int[] nums1, int[] nums2)
        {
            int p1 = 0, p2 = 0;

            while (p1 < nums1.Length && p2 < nums2.Length)
            {
                if (nums1[p1] == nums2[p2]) return nums1[p1];

                if (nums1[p1] > nums2[p2]) p2++;
                else p1++;
            }

            return -1;
        }
    }
}
