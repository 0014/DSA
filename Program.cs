using DSA.Helpers;

var raw = Console.In.ReadToEnd().Trim();
var lines = InputParser.SplitLines(raw);

var s = InputParser.ParseString(lines[0]);
var t = InputParser.ParseString(lines[1]);
var maxCost = InputParser.ParseInt(lines[2]);

var sol = new DSA.Solutions.P1208_GetEqualSubstringsWithinBudget.Solution();
var answer = sol.EqualSubstring(s, t, maxCost);

Console.WriteLine(answer);

//foreach (var i in answer)
//{
//    Console.Write(i + " ");
//}