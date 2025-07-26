/* * LeetCode Problem 303: Range Sum Query - Immutable
 * https://leetcode.com/problems/range-sum-query-immutable/
 * Description:
 * Given an integer array nums, handle multiple queries of the following type:
 * - Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
 */
namespace DSA.Solutions.ArraysAndStrings.P303_RangeSumQueryImmutable
{
    public class NumArray
    {

        private int[] _prefix;
        private int[] _nums;

        public NumArray(int[] nums)
        {
            _nums = nums;
            _prefix = new int[nums.Length];
            _prefix[0] = nums[0];

            for (var i = 1; i < _prefix.Length; i++)
                _prefix[i] = _prefix[i - 1] + nums[i];
        }

        public int SumRange(int left, int right)
        {
            return _prefix[right] - _prefix[left] + _nums[left];
        }
    }

    /**
     * Your NumArray object will be instantiated and called as such:
     * NumArray obj = new NumArray(nums);
     * int param_1 = obj.SumRange(left,right);
     */
}
