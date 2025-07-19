using System.Text.Json;

namespace DSA.Helpers
{
    public static class InputParser
    {
        public static string[] SplitLines(string s)
            => s.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

        public static int ParseInt(string s)
            => int.Parse(s.Trim());

        public static long ParseLong(string s)
            => long.Parse(s.Trim());

        public static double ParseDouble(string s)
            => double.Parse(s.Trim());

        public static string ParseString(string s)
            => s.Trim().Trim('\"');

        public static int[] ParseIntArray(string s)
            => JsonSerializer.Deserialize<int[]>(s)!;

        public static int?[] ParseNullableIntArray(string s)
            => JsonSerializer.Deserialize<int?[]>(s)!;

        public static int[][] Parse2DIntArray(string s)
            => JsonSerializer.Deserialize<int[][]>(s)!;

        public static List<List<int>> ParseList2D(string s)
            => JsonSerializer.Deserialize<List<List<int>>>(s)!;

        public static string[] ParseStringArray(string s)
            => JsonSerializer.Deserialize<string[]>(s)!;

        // Example for binary tree inputs like [3,9,20,null,null,15,7]
        public static TreeNode? ParseTree(string s)
        {
            var vals = JsonSerializer.Deserialize<int?[]>(s)!;
            if (vals.Length == 0 || !vals[0].HasValue) return null;

            var root = new TreeNode(vals[0].Value);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int i = 1;
            while (queue.Count > 0 && i < vals.Length)
            {
                var node = queue.Dequeue();
                if (vals[i].HasValue)
                {
                    node.left = new TreeNode(vals[i].Value);
                    queue.Enqueue(node.left);
                }
                i++;
                if (i < vals.Length && vals[i].HasValue)
                {
                    node.right = new TreeNode(vals[i].Value);
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return root;
        }
    }

    // Simple TreeNode definition you can reuse for tree problems
    public class TreeNode
    {
        public int val;
        public TreeNode? left, right;
        public TreeNode(int v = 0) { val = v; }
    }
}
