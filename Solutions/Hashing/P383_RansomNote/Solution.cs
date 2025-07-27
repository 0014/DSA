/* Problem: https://leetcode.com/problems/ransom-note/
   Difficulty: Easy
   Tags: Hash Table, String, Counting
    Description: Given two strings ransomNote and magazine, return true if ransomNote can be constructed from magazine and false otherwise.
    Each letter in magazine can only be used once in ransomNote.
 */
namespace DSA.Solutions.Hashing.P383_RansomNote
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var counts = new int[26];

            foreach (var c in ransomNote) counts[c - 'a']++;
            foreach (var c in magazine) counts[c - 'a']--;
            foreach (var i in counts) if (i > 0) return false;

            return true;
        }
    }
}
