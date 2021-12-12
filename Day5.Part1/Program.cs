// See https://aka.ms/new-console-template for more information

using AdventOfCode.Helpers;

var path = Path.Combine(Directory.GetCurrentDirectory(), "input.data");
var data = FileHelper.GetDataFromInput(path);

foreach(var item in data)
{
    var maxX = 0;
    var x1 = int.Parse(item.Split("->")[0].Split(',')[0]);
    var x2 = int.Parse(item.Split("->")[1].Split(',')[0]);

    var biggestX = new List<int> { x1, x2 }.Max();

    if (biggestX > maxX)
    {
        maxX = biggestX;
    }

    Console.WriteLine($"Max X {maxX}");
}

Console.ReadLine();