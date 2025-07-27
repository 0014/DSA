/*
 * You are given an integer array matches where matches[i] = [winneri, loseri] indicates that the player winneri defeated player loseri in a match.
 * Return a list answer of size 2 where:
 * * answer[0] is a list of all players that have not lost any matches.
 * * answer[1] is a list of all players that have lost exactly one match.
 * The values in the two lists should be returned in increasing order.
 * Note:
 * * You should only consider the players that have played at least one match.
 * * The testcases will be generated such that no two matches will have the same outcome.
 */
namespace DSA.Solutions.Hashing.P2225_FindPlayersWithZeroOrOneLosses
{
    public class Solution
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            var wins = new Dictionary<int, int>();
            var loss = new Dictionary<int, int>();

            foreach (var match in matches)
            {
                if (wins.ContainsKey(match[0])) wins[match[0]]++;
                else wins.Add(match[0], 1);

                if (loss.ContainsKey(match[1])) loss[match[1]]++;
                else loss.Add(match[1], 1);
            }

            var notLost = new List<int>();
            wins = wins.OrderBy(x => x.Key).ToDictionary();
            foreach (var win in wins)
            {
                if (!loss.ContainsKey(win.Key)) notLost.Add(win.Key);
            }

            var lostOnce = new List<int>();
            loss = loss.OrderBy(x => x.Key).ToDictionary();
            foreach (var los in loss)
            {
                if (los.Value == 1) lostOnce.Add(los.Key);
            }

            return new List<IList<int>>() { notLost, lostOnce };
        }
    }
}
