namespace DSA.Solutions.P2000_ReversePrefixOfWord
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

            return new String(arr);
        }
    }
}
