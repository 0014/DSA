/* Given a string path, where path[i] = 'N', 'S', 'E' or 'W', each representing moving one unit north, south, east, or west, respectively. You start at the origin (0, 0) on a 2D plane and walk on the path specified by path.
 * Return true if the path crosses itself at any point, that is, if at any time you are on a location you have previously visited. Return false otherwise.
*/
namespace DSA.Solutions.Hashing.P1496_PathCrossing
{
    public class Solution
    {
        public bool IsPathCrossing(string path)
        {
            var set = new HashSet<string>();
            var x = 0; var y = 0;
            set.Add($"{x},{y}");
            foreach (var direction in path)
            {
                switch (direction)
                {
                    case 'N':
                        y++;
                        break;
                    case 'E':
                        x++;
                        break;
                    case 'S':
                        y--;
                        break;
                    case 'W':
                        x--;
                        break;
                }
                var coordinates = $"{x},{y}";
                if (set.Contains(coordinates)) return true;
                set.Add(coordinates);
            }

            return false;
        }
    }
}
