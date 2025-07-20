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
