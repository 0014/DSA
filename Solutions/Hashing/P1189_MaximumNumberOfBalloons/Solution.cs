/* 
 * LeetCode Problem: https://leetcode.com/problems/maximum-number-of-balloons/
 * Difficulty: Easy
 * Tags: Hash Table, String, Counting
 * Description:
 * Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
 * You can use each character in text at most once. Return the maximum number of instances that can be formed.
 */
namespace DSA.Solutions.Hashing.P1189_MaximumNumberOfBalloons
{
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            var counts = new Dictionary<char, int>();

            foreach (var c in text)
            {
                if (counts.ContainsKey(c)) counts[c]++;
                else counts.Add(c, 1);
            }

            if (!counts.ContainsKey('b') || !counts.ContainsKey('a') || !counts.ContainsKey('l') || !counts.ContainsKey('o') || !counts.ContainsKey('n')) return 0;

            var min = int.MaxValue;
            min = Math.Min(min, counts['b']);
            min = Math.Min(min, counts['a']);
            min = Math.Min(min, counts['l'] / 2);
            min = Math.Min(min, counts['o'] / 2);
            min = Math.Min(min, counts['n']);
            return min;
        }
    }
}
