// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
var timeStart = Stopwatch.StartNew();
var filePath = Path.Combine(Directory.GetCurrentDirectory(), "input.data");
var inputData = File.ReadAllLines(filePath).ToList();

int numberOfIncreasedDepths = 0;
int? previousResult = null;

inputData.ForEach(
    x =>
    {
        int.TryParse(x, out int num);

        if (previousResult == null)
        {
            previousResult = 0;
            return;
        }       

        if (num > previousResult)
        {
            numberOfIncreasedDepths += 1;
        }
        previousResult = num;

    });

Console.WriteLine($"Number of increased depths is: {numberOfIncreasedDepths}");
timeStart.Stop();
Console.WriteLine($"Elapsed time: {timeStart.Elapsed}");
