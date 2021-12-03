// See https://aka.ms/new-console-template for more information 
using Day3.Part1;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
var timeStart = Stopwatch.StartNew();
var filePath = Path.Combine(Directory.GetCurrentDirectory(), "input.data");

var rawData = File.ReadAllLines(filePath);

List<int> bit1 = new();
List<int> bit2 = new();
List<int> bit3 = new();
List<int> bit4 = new();
List<int> bit5 = new();
List<int> bit6 = new();
List<int> bit7 = new();
List<int> bit8 = new();
List<int> bit9 = new();
List<int> bit10 = new();
List<int> bit11 = new();
List<int> bit12 = new();

for (var i = 0; i < rawData.Length; i++)
{
    bit1.Add(int.Parse(rawData[i].Substring(0,1)));
    bit2.Add(int.Parse(rawData[i].Substring(1,1)));
    bit3.Add(int.Parse(rawData[i].Substring(2,1)));
    bit4.Add(int.Parse(rawData[i].Substring(3,1)));
    bit5.Add(int.Parse(rawData[i].Substring(4,1)));
    bit6.Add(int.Parse(rawData[i].Substring(5,1)));
    bit7.Add(int.Parse(rawData[i].Substring(6,1)));
    bit8.Add(int.Parse(rawData[i].Substring(7,1)));
    bit9.Add(int.Parse(rawData[i].Substring(8,1)));
    bit10.Add(int.Parse(rawData[i].Substring(9,1)));
    bit11.Add(int.Parse(rawData[i].Substring(10,1)));
    bit12.Add(int.Parse(rawData[i].Substring(11,1)));
}

var gamma = $"{bit1.FindMostCommon()}{bit2.FindMostCommon()}{bit3.FindMostCommon()}{bit4.FindMostCommon()}{bit5.FindMostCommon()}{bit6.FindMostCommon()}{bit7.FindMostCommon()}{bit8.FindMostCommon()}{bit9.FindMostCommon()}{bit10.FindMostCommon()}{bit11.FindMostCommon()}{bit12.FindMostCommon()}";
var gammaAsDigital = Convert.ToInt32(gamma,2);

Console.WriteLine($"Gamma: {gammaAsDigital}");


var epsilon = $"{bit1.FindLeastCommon()}{bit2.FindLeastCommon()}{bit3.FindLeastCommon()}{bit4.FindLeastCommon()}{bit5.FindLeastCommon()}{bit6.FindLeastCommon()}{bit7.FindLeastCommon()}{bit8.FindLeastCommon()}{bit9.FindLeastCommon()}{bit10.FindLeastCommon()}{bit11.FindLeastCommon()}{bit12.FindLeastCommon()}";
var epsilonAsDigital = Convert.ToInt32(epsilon, 2);

Console.WriteLine($"Epsilon: {epsilonAsDigital}");

var powerConsumption = epsilonAsDigital * gammaAsDigital;

Console.WriteLine($"Power Consumption: {powerConsumption}");

timeStart.Stop();
Console.WriteLine($"Elapsed time: {timeStart.Elapsed}");