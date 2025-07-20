namespace DSA.Solutions.ArraysAndStrings.P724_FindPivotIndex
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            var prefix = new int[nums.Length];
            prefix[0] = nums[0];

            for (var i = 1; i < prefix.Length; i++)
                prefix[i] = prefix[i - 1] + nums[i];


            for (var i = 0; i < prefix.Length; i++)
            {
                var left = i == 0 ? 0 : prefix[i - 1];
                var right = prefix[prefix.Length - 1] - prefix[i];

                if (left == right) return i;
            }

            return -1;
        }
    }
}
