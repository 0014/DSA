using DSA.Helpers;

var raw = Console.In.ReadToEnd().Trim();
var lines = InputParser.SplitLines(raw);

var nums = InputParser.ParseIntArray(lines[0]);

var sol = new DSA.Solutions.Hashing.P1748_SumOfUniqueElements.Solution();
var answer = sol.SumOfUnique(nums);

Console.WriteLine(answer);

//foreach (var i in answer)
//{
//    Console.Write(i + " ");
//}