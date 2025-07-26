/*
 * LeetCode Problem: https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
 * Difficulty: Easy
 * Tags: Sliding Window, String
 * Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.
 * Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.
 */

namespace DSA.Solutions.ArraysAndStrings.P1456_MaximumNumberOfVowelsInASubstringOfGivenLength
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
