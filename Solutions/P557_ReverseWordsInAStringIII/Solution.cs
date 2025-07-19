namespace DSA.Solutions.P557_ReverseWordsInAStringIII
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
