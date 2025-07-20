namespace DSA.Solutions.ArraysAndStrings.P1208_GetEqualSubstringsWithinBudget
{
    public class Solution
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            var l = 0;
            var cost = 0;
            var curr = 0;
            var ans = 0;

            for (var r = 0; r < s.Length; r++)
            {
                if (s[r] != t[r])
                    cost += Math.Abs(s[r] - t[r]);

                while (l <= r && cost > maxCost)
                {
                    cost -= Math.Abs(s[l] - t[l]);
                    curr--; l++;
                }

                curr++;
                ans = Math.Max(ans, curr);
            }

            return ans;
        }
    }
}
