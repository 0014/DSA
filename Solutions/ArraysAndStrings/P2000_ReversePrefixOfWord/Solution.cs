﻿/* * LeetCode Problem 2000: Reverse Prefix of Word
 * 
 * Given a string word and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive).
 * If ch does not exist in word, do nothing.
 * Return the resulting string.
 */

namespace DSA.Solutions.ArraysAndStrings.P2000_ReversePrefixOfWord
{
    public class Solution
    {
        public string ReversePrefix(string word, char ch)
        {
            int l = 0, r = 0;
            var arr = word.ToCharArray();

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ch)
                {
                    while (l < r)
                    {
                        var temp = arr[r];
                        arr[r] = arr[l];
                        arr[l] = temp;
                        l++;
                        r--;
                    }
                    break;
                }

                r++;
            }

            return new string(arr);
        }
    }
}
