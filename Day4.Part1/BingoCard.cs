// See https://aka.ms/new-console-template for more information
class BingoCard
{
    public int CardId { get; set; }

    public List<Line> Lines { get; set; } = new List<Line>();

    public List<Column> Columns { get; set; } = new List<Column>();

    public BingoCard(List<int> cardNumbers, int id)
    {

        if (cardNumbers.Count() != 25)
        {
            throw new ArgumentException("Incorrect amount of numbers");
        }

        for (var i = 0; i < cardNumbers.Count(); i += 5)
        {
            Lines.Add(GenerateLine(i + 1, cardNumbers.ToList().Skip(i).Take(5).ToList()));
            Columns.Add(new Column(i + 1, cardNumbers[0], cardNumbers[5], cardNumbers[10], cardNumbers[15], cardNumbers[20]));
        }


        CardId = id;
    }

    private Line GenerateLine(int lineId, List<int> numbers)
    {
        var line = new Line(lineId, numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
        return line;
    }


    internal void Print()
    {
        Console.WriteLine($"------------------ START CARD {CardId} ------------------");
        Console.WriteLine();
        foreach (var line in Lines)
        {
            foreach (var number in line.GetNumbers())
            {
                Console.Write($"{number}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("------------------- END CARD -------------------");

    }

    internal void PlayNumber(int playedNumber)
    {
        foreach (var column in Columns)
        {
            if (column.Numbers.Contains(playedNumber))
            {
                column.Numbers.Remove(playedNumber);
            }

            if (column.Numbers.Count() == 0)
            {
                Console.WriteLine("COLUMN");
                Console.WriteLine($"Card {CardId} has a column on column {column.Id}");
                Console.WriteLine($"Last number played was {playedNumber}");

                CalculateWinningScore(Lines, playedNumber);

                Environment.Exit(1);
            }
        }
        foreach (var line in Lines)
        {
            if (line.Numbers.Contains(playedNumber))
            {
                line.Numbers.Remove(playedNumber);
            }

            if (line.Numbers.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("LINE");
                Console.WriteLine($"Card {CardId} has a line on line {line.Id}");
                Console.WriteLine($"Last number played was {playedNumber}");

                CalculateWinningScore(Lines, playedNumber);

                Environment.Exit(1);
            }
        }
    }

    private void CalculateWinningScore(List<Line> lines, int winningNumber)
    {
        int sumOfTotalLeftOver = 0;
        foreach (var l in lines)
        {
            sumOfTotalLeftOver += l.Numbers.Sum();
        }
        Console.WriteLine($"Winning score: {sumOfTotalLeftOver}");
        Console.WriteLine($"{sumOfTotalLeftOver} * {winningNumber} = {sumOfTotalLeftOver * winningNumber}");


    }

    private bool IsMatch(int number1, int number2)
    {
        return number1 == number2;
    }
}