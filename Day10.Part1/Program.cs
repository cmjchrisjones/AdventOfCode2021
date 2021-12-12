// See https://aka.ms/new-console-template for more information
using AdventOfCode.Helpers;

Console.WriteLine("Hello, World!");

var data = FileHelper.GetDataFromInput(Path.Combine(Directory.GetCurrentDirectory(), "test-input.data"));
char[] terminatingCharacters = new char[] { ')', ']', '}', '>' };
char[] initiatingCharacters = new char[] { '(', '[', '{', '<' };
int score = 0;

foreach (var item in data)
{
    List<char> opening = new();
    List<char> illegalCharacters = new();

    var chars = item.ToCharArray().ToList();

    var index = 1;
    foreach (var c in chars)
    {
        if (initiatingCharacters.Contains(c))
        {
            opening.Add(c);
        }
        else if (terminatingCharacters.Contains(c))
        {
            // try removing back from the openings 
            if (opening.Last() == Swap(c))
            {
                opening.RemoveAt(opening.LastIndexOf(Swap(c)));
            }
            else
            {
                Console.WriteLine($"Line {item}: Expected {Swap(opening.Last())}, but found {c} instead");
                score += IllegalCharacterScore(c);
                break;
            }
        }
        else
        {
            Console.WriteLine($"Line {item} incomplete");
            break;
        }
        index++;
    }
}
Console.WriteLine($"Score {score}");
Console.ReadLine();

static char Swap(char input)
{  
    return input switch
    {
        '(' => ')',
        '[' => ']',
        '{' => '}',
        '<' => '>',
        ')' => '(',
        ']' => '[',
        '}' => '{',
        '>' => '<',
        _=> '0'
    };
}

static int IllegalCharacterScore(char c)
{
    return c switch
    {
        ')' => 3,
        ']' => 57,
        '}' => 1197,
        '>' => 25137,
        _ => 0,
    };
}