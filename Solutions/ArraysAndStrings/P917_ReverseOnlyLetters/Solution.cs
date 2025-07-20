namespace DSA.Solutions.ArraysAndStrings.P917_ReverseOnlyLetters
{
    public class Solution
    {
        public string ReverseOnlyLetters(string s)
        {
            var arr = s.ToCharArray();

            int l = 0, r = arr.Length - 1;
            while (l < r)
            {
                if (!IsEnglishLetter(arr[l]))
                {
                    l++;
                    continue;
                }
                if (!IsEnglishLetter(arr[r]))
                {
                    r--;
                    continue;
                }
                var temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }

            return new string(arr);
        }

        private bool IsEnglishLetter(char c)
        {
            return c >= 65 && c <= 90 || c >= 97 && c <= 122;
        }
    }
}
