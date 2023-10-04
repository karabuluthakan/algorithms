Console.WriteLine("https://leetcode.com/problems/find-center-of-star-graph/");

var firstInput = new List<Vector>
{
    new() { Vertical = 1, Horizontal = 2 },
    new() { Vertical = 2, Horizontal = 3 },
    new() { Vertical = 4, Horizontal = 2 }
};
var secondInput = new List<Vector>
{
    new() { Vertical = 1, Horizontal = 2 },
    new() { Vertical = 5, Horizontal = 1 },
    new() { Vertical = 1, Horizontal = 3 },
    new() { Vertical = 1, Horizontal = 4 }
};
var solution = new Solution();
var firstResult = solution.FindCenter(firstInput);
var secondResult = solution.FindCenter(secondInput);

Console.WriteLine($"First input center of Graph : {firstResult.ToString()}");
Console.WriteLine($"Second input center of Graph : {secondResult.ToString()}");