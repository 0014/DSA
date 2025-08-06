/* LeetCode Problem 917: Reverse Only Letters
 * 
 * Given a string s, return the string after replacing every letter with its reverse in the alphabet,
 * where 'a' is replaced by 'z', 'b' is replaced by 'y', and so on.
 * Non-letter characters remain unchanged.
 */
namespace DSA.Solutions.ArraysAndStrings.P0917_ReverseOnlyLetters
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
