/*
 * LeetCode Problem: https://leetcode.com/problems/check-if-the-sentence-is-pangram/
 * Difficulty: Easy
 * Tags: String, Hash Table, Counting
 * 
 * Description:
 * A pangram is a sentence that contains every single letter of the alphabet at least once.
 * Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.
*/
namespace DSA.Solutions.P1832_CheckIfTheSentenceIsPangram
{
    public class Solution
    {
        public bool CheckIfPangram(string sentence)
        {
            if (sentence.Length < 26) return false;

            var set = new HashSet<char>();
            for (var i = 97; i <= 122; i++) set.Add((char)i);

            foreach (var c in sentence) if (set.Remove(c)) ;

            return set.Count == 0;
        }
    }
}
