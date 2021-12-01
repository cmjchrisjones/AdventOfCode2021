// See https://aka.ms/new-console-template for more information

/*
 
Start by comparing the first and second three-measurement windows. 
The measurements in the first window are marked A (199, 200, 208); their sum is 199 + 200 + 208 = 607.
The second window is marked B (200, 208, 210); its sum is 618. 
The sum of measurements in the second window is larger than the sum of the first, so this first comparison increased.

Your goal now is to count the number of times the sum of measurements in this sliding window increases from the previous sum. 
So, compare A with B, then compare B with C, then C with D, and so on. 
Stop when there aren't enough measurements left to create a new three-measurement sum.
 
 */

using System.Diagnostics;

Console.WriteLine("Hello, World!");
var timeStart = Stopwatch.StartNew();
var filePath = Path.Combine(Directory.GetCurrentDirectory(), "input.data");
var inputData = File.ReadAllLines(filePath).ToList();

int numberOfIncreasedDepths = 0;
int? sumOfPreviousResult = null;
int counter = 0;

for (var i = 0; i < inputData.Count(); i++)
{
    if (sumOfPreviousResult == null)
    {
        sumOfPreviousResult = 0;
        continue;
    }


    var toSkip = counter <= 3 ? i : counter;
    var data = inputData.Skip(toSkip).Take(3);
    if (data.Count() < 3)
    {
        // No more results to calculate a meaningful output.
        break;
    }

    int y = 0;
    data.ToList().ForEach(x => y += int.Parse(x));

    if (y > sumOfPreviousResult)
    {
        numberOfIncreasedDepths++;
    }

    sumOfPreviousResult = y;
    counter++; 
};

Console.WriteLine($"Number of increased depths is: {numberOfIncreasedDepths}");
timeStart.Stop();
Console.WriteLine($"Elapsed time: {timeStart.Elapsed}");