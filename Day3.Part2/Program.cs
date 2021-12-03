using Day3.Part2;
using System.Diagnostics;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var timeStart = Stopwatch.StartNew();
var filePath = Path.Combine(Directory.GetCurrentDirectory(), "input.data");

var rawData = File.ReadAllLines(filePath).ToList();

var mostCommon = rawData;
var leastCommon = rawData;


foreach (var item in mostCommon)
{
    for (int j = 0; j < item.Length; j++)
    {
        var mostCommonDigit = MostCommonAtIndex(mostCommon, j);
        mostCommon = mostCommon.Where(_ => _.Substring(j, 1) == mostCommonDigit).ToList();
    }
}

foreach (var item in leastCommon)
{
    for (int j = 0; j < item.Length; j++)
    {
        var leastCommonDigit = LeastCommonAtIndex(leastCommon, j);
        leastCommon = leastCommon.Where(_ => _.Substring(j, 1) == leastCommonDigit).ToList();
    }
}

mostCommon.ForEach(_ => Console.WriteLine(_));
leastCommon.ForEach(_ => Console.WriteLine(_));

var mostCommonAsDecimal = Convert.ToInt32(mostCommon[0], 2);
var leastCommonAsDecimal = Convert.ToInt32(leastCommon[0], 2);

Console.Write($"Life support rating: {mostCommonAsDecimal* leastCommonAsDecimal}");

Console.Read();

string MostCommonAtIndex(List<string> list, int index)
{
    List<string> indexedDigit = new();
    foreach (var data in list)
    {
        var digit = data.Substring(index, 1);
        indexedDigit.Add(digit);
    }

    return indexedDigit.FindMostCommon();
}


string LeastCommonAtIndex(List<string> list, int index)
{
    List<string> indexedDigit = new();
    foreach (var data in list)
    {
        var digit = data.Substring(index, 1);
        indexedDigit.Add(digit);
    }

    return indexedDigit.FindLeastCommon();
}