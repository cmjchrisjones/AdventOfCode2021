// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var input = new long[5] { 2199943210, 3987894921, 9856789892, 8767896789, 9899965678 };

HeightMapLowPoints(input);

Console.ReadLine();

int HeightMapLowPoints(long[] heightmaps)
{
    int lowPoints = 0;
    int line, col = 0;
    
    foreach(var heightmap in heightmaps)
    {
        var positions = heightmap.ToString().ToArray();
        foreach (int pos in positions)
        {
            
        }
    }
    return lowPoints;
}