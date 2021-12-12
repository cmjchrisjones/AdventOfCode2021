// See https://aka.ms/new-console-template for more information
using AdventOfCode.Helpers;

Console.WriteLine("Hello, World!");


/*
 
 
 dddd
e    a
e    a
 ffff
g    b
g    b
 cccc


 */

var input = FileHelper.GetDataFromInput("input.data");

int uniqueNumbers = 0;
foreach (var pattern in input)
{
    var signalPatterns = pattern.Split('|')[0].Split(' ');
    var outputValue = pattern.Split('|')[1].Split(' ');
    Console.WriteLine();
    signalPatterns.ToList().ForEach(_ => Console.Write($"{Convert(_)}"));
    Console.Write("\t");
    foreach (var o in outputValue)
    {
        Console.Write(Convert(o));
    }
}
Console.WriteLine($"Unique numbers: {uniqueNumbers}");
Console.ReadLine();

int? Convert(string outputValue)
{
    int? output = null;
    if (!string.IsNullOrEmpty(outputValue))
    {
        switch (outputValue.Length)
        {
            case 0:
            case 1:
                break;

            case 2:
                output = 1;
                break;
            case 3:
                output = 7;
                break;
            case 4:
                output = 4;
                break;
            case 5:
                if (outputValue.Equals("fbcad"))
                {
                    output = 3;
                }
                if (outputValue.Equals("gcdfa"))
                {
                    output = 2;
                }
                if (outputValue.Equals("fbcad"))
                {
                    output = 3;
                }
                break;
            case 6:
                if (outputValue.Equals("cdfgeb"))
                {
                    output = 6;
                }
                if (outputValue.Equals("cagedb"))
                {
                    output = 0;
                }
                if (outputValue.Equals("cefabd"))
                {
                    output = 9;
                }
                break;
            case 7:
                output = 8;
                break;
        }
    }

    if (output == null && outputValue.Length > 0)
    {
        if (outputValue.Contains('d') && outputValue.Contains('f') && outputValue.Contains('c'))
        {
            // its either 2, 3, 5,6 or 8
            if (outputValue.Contains('a') && outputValue.Contains('c'))
            {
                output = 2;
            }
            if (outputValue.Contains('a') && outputValue.Contains('b'))
            {
                output = 3;
            }
            if (outputValue.Contains('e') && outputValue.Contains('b'))
            {
                output = 5;
            }
            if (outputValue.Contains('e') && outputValue.Contains('g'))
            {
                output = 6;
            }
            if (outputValue.Contains('a') && outputValue.Contains('b') && outputValue.Contains('f') && outputValue.Contains('g'))
            {
                output = 8;
            }

        }
    }
    return output;
}