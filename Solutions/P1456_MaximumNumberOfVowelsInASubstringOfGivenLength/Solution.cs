namespace DSA.Solutions.P1456_MaximumNumberOfVowelsInASubstringOfGivenLength
{
    public class Solution
    {
        public int MaxVowels(string s, int k)
        {
            var arr = s.ToCharArray();

            var curr = 0;
            for (var i = 0; i < k; i++)
                if (IsVowel(arr[i])) curr++;

            var ans = curr;
            for (var i = k; i < arr.Length; i++)
            {
                if (IsVowel(arr[i])) curr++;
                if (IsVowel(arr[i - k])) curr--;
                ans = Math.Max(ans, curr);
            }
            return ans;
        }

        private bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
