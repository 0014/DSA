/*
 * You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.
 * It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
 */
namespace DSA.Solutions.Hashing.P1436_DestinationCity
{
    public class Solution
    {
        public string DestCity(IList<IList<string>> paths)
        {
            var dic = new Dictionary<string, string>();
            foreach (var path in paths) dic.Add(path[0], path[1]);

            foreach (var kvp in dic)
            {
                if (!dic.ContainsKey(kvp.Value)) return kvp.Value;
            }
            return "";
        }
    }
}
