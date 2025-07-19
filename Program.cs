using DSA.Helpers;

var raw = Console.In.ReadToEnd().Trim();
var lines = InputParser.SplitLines(raw);

var nums1 = InputParser.ParseIntArray(lines[0]);
var nums2 = InputParser.ParseIntArray(lines[1]);
//var k = InputParser.ParseInt(lines[1]);
//var s = InputParser.ParseString(lines[0]);

var sol = new DSA.Solutions.P2540_MinimumCommonValue.Solution();
var answer = sol.GetCommon(nums1, nums2);

Console.WriteLine(answer);

//foreach (var i in answer)
//{
//    Console.Write(i + " ");
//}