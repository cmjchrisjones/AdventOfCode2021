// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("Hello, World!");
var timeStart = Stopwatch.StartNew();
var filePath = Path.Combine(Directory.GetCurrentDirectory(), "input.data");
int horizontal, depth = 0;

var rawData = File.ReadAllLines(filePath);

List<KeyValuePair<string, int>> directions = new();

rawData.ToList().ForEach(
        x =>
        {
            string[]? direction = x.Split(' ');
            directions.Add(new KeyValuePair<string, int>(direction[0], int.Parse(direction[1])));
        });

var forward = directions.Where(x => x.Key == "forward").Select(_=>_.Value).Sum();
var dive = directions.Where(x => x.Key == "down").Select(_ => _.Value).Sum();
var rise = directions.Where(x => x.Key == "up").Select(_ => _.Value).Sum();

horizontal = forward;
depth = dive - rise;

var position = horizontal * depth;

Console.WriteLine($"Position is {position}");

timeStart.Stop();
Console.WriteLine($"Elapsed time: {timeStart.Elapsed}");