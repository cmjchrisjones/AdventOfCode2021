// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("Hello, World!");
var timeStart = Stopwatch.StartNew();
var filePath = Path.Combine(Directory.GetCurrentDirectory(), "input.data");

var rawData = File.ReadAllLines(filePath);

List<KeyValuePair<string, int>> directions = new();
int horizontal = 0, depth = 0, aim = 0;

rawData.ToList().ForEach(
        x =>
        {
            string[]? direction = x.Split(' ');
            directions.Add(new KeyValuePair<string, int>(direction[0], int.Parse(direction[1])));
        });

directions.ForEach(
    direction =>
    {
        if (direction.Key == "forward")
        {
            if (aim == 0)
            {
                horizontal += direction.Value;
                return;
            }
            horizontal += direction.Value;
            depth += aim * direction.Value;
        }

        if (direction.Key == "down")
        {
            aim += direction.Value;
        }

        if (direction.Key == "up")
        {
            aim -= direction.Value;
        }
    });

Console.WriteLine($"D: {depth}");
Console.WriteLine($"H: {horizontal}");
Console.WriteLine($"A: {aim}");

var position = horizontal * depth;

Console.WriteLine($"Position is {position}");

timeStart.Stop();
Console.WriteLine($"Elapsed time: {timeStart.Elapsed}");