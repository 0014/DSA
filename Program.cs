using DSA.Helpers;

var raw = Console.In.ReadToEnd().Trim();
var lines = InputParser.SplitLines(raw);

var nums = InputParser.ParseIntArray(lines[0]);

var sol = new DSA.Solutions.Hashing.P525_ContiguousArray.Solution();
var answer = sol.FindMaxLength(nums);

Console.WriteLine(answer);

//foreach (var i in answer)
//{
//    Console.Write(i + " ");
//}