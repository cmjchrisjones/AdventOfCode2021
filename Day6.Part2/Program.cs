// See https://aka.ms/new-console-template for more information
using AdventOfCode.Helpers;
using System.Text;

Console.WriteLine("Hello, World!");


var fish = new List<int> { 3, 4, 3, 1, 2 };
var filePath = Path.Combine(Directory.GetCurrentDirectory(), "output.txt");

if (!File.Exists(filePath))
{
    Console.WriteLine("File doesn't exist... creating");
    File.Create(filePath);
    WriteToFile(filePath, fish); 
}
else
{
    Console.WriteLine("File exists");
}

List<int> listAsInt;
int day = 0;
while(day < 256)
{
    listAsInt = new List<int>();
    var file = File.ReadAllLines(filePath);

    var list = file.Last().Split(',').ToList();
    foreach (var f in list)
    {
            listAsInt.Add(int.Parse(f));
    }

    List<int> newFish = new();
    List<int> newState = new();

    foreach(var f in listAsInt)
    {
        if(f == 0)
        {
            newFish.Add(8);
            newState.Add(6);
            continue;
        }
        newState.Add(f - 1);
    }

    List<int> updatedList = new();
    updatedList.AddRange(newState);
    updatedList.AddRange(newFish);
    WriteToFile(filePath, updatedList);
    Console.WriteLine($"Day {day+1} has {updatedList.Count()} fish");
    day++;
}

Console.ReadLine();

void WriteToFile(string filePath, List<int> list)
{

    var toAppend = new StringBuilder();
    toAppend.AppendLine();

    foreach (var f in list)
    {
        toAppend.Append($"{f},");
    } 

    toAppend.Remove(toAppend.Length - 1, 1);

    File.AppendAllText(filePath, toAppend.ToString());

}