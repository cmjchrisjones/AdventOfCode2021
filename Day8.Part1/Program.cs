// See https://aka.ms/new-console-template for more information
using AdventOfCode.Helpers;

Console.WriteLine("Hello, World!");


/*
 
 
 0:          1:             2:            3:                4:
 aaaa        ....           aaaa          aaaa              ....
b    c      .    c         .    c        .    c            b    c
b    c      .    c         .    c        .    c            b    c
 ....        ....           dddd          dddd              dddd
e    f      .    f         e    .        .    f            .    f
e    f      .    f         e    .        .    f            .    f
 gggg        ....           gggg          gggg              ....
                                                           
  5:          6:             7:            8:                9:
 aaaa        aaaa           aaaa          aaaa              aaaa
b    .      b    .         .    c        b    c            b    c
b    .      b    .         .    c        b    c            b    c
 dddd        dddd           ....          dddd              dddd
.    f      e    f         .    f        e    f            .    f
.    f      e    f         .    f        e    f            .    f
 gggg        gggg           ....          gggg              gggg
 
 
 */

var input = FileHelper.GetDataFromInput("input.data");

int uniqueNumbers = 0;
foreach (var pattern in input)
{
    var signalPatterns = pattern.Split('|')[0].Split(' ');
    var outputValue = pattern.Split('|')[1].Split(' ');
    foreach (var o in outputValue)
        if (Print(o))
        {
            uniqueNumbers++;
        };
}
Console.WriteLine($"Unique numbers: {uniqueNumbers}");
Console.ReadLine();

bool Print(string outputValue)
{
    var isUnique = false;
     
    switch (outputValue.Length)
    {
        case 0:
        case 1:
            break;

        case 2:
            Console.Write("1");
            isUnique = true;
            break;
        case 3:
            Console.Write("7");
            isUnique = true;
            break;
        case 4:
            Console.Write("4");
            isUnique = true;
            break;
        case 5:
            //Console.Write("2/3/5");
            break;
        case 6:
            //Console.Write("0/6/9");
            break;
        case 7:
            Console.Write("8");
            isUnique = true;
            break;
    }
    Console.WriteLine();
    return isUnique;

}