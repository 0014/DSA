/* * LeetCode Problem 557: Reverse Words in a String III
 * https://leetcode.com/problems/reverse-words-in-a-string-iii/
 *
 * Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
 */
namespace DSA.Solutions.ArraysAndStrings.P557_ReverseWordsInAStringIII
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var result = "";
            var words = s.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i].ToCharArray();
                var l = 0;
                var r = word.Length - 1;

                while (l < r)
                {
                    var temp = word[l];
                    word[l] = word[r];
                    word[r] = temp;

                    l++; r--;
                }
                result += new string(word);
                if (i != words.Length - 1) result += " ";
            }

            return result;
        }
    }
}
