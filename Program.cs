using DSA.Helpers;

var raw = Console.In.ReadToEnd().Trim();
var lines = InputParser.SplitLines(raw);

var s = InputParser.ParseString(lines[0]);
var t = InputParser.ParseString(lines[1]);

var sol = new DSA.Solutions.Hashing.P0205_IsomorphicStrings.Solution();
var answer = sol.IsIsomorphic(s, t);

Console.WriteLine(answer);

//foreach (var i in answer)
//{
//    Console.Write(i + " ");
//}