﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

List<BingoCard> WinningCard = new List<BingoCard>();

var puzzleInput = new int[] { 7, 4, 9, 5, 11, 17, 23, 2, 0, 14, 21, 24, 10, 16, 13, 6, 15, 25, 12, 22, 18, 20, 8, 19, 3, 26, 1 };

var bingoCardInput = new int[] {
22, 13, 17, 11, 0,
 8,  2, 23,  4, 24,
21,  9, 14, 16,  7,
 6, 10,  3, 18,  5,
 1, 12, 20, 15, 19,

 3, 15, 0,  2, 22,
 9, 18, 13, 17,  5,
19,  8,  7, 25, 23,
20, 11, 10, 24,  4,
14, 21, 16, 12,  6,

14, 21, 17, 24,  4,
10, 16, 15,  9, 19,
18,  8, 23, 26, 20,
22, 11, 13,  6,  5,
 2,  0, 12,  3,  7};


var timeStart = Stopwatch.StartNew();
var filePath = Path.Combine(Directory.GetCurrentDirectory(), "input.data");

//var rawData = File.ReadAllLines(filePath);
List<int> bingoNumbers = new();
//foreach (var num in rawData[0].Split(','))
//{
//    bingoNumbers.Add(int.Parse(num));
//}

//var cardNumbers = rawData.ToList().Where(_ => _ != string.Empty).Skip(1).ToList();


List<int> cardNumbersAsInt = new();
//foreach (var num in cardNumbers)
//{
//    num.Split(' ')
//        .ToList()
//        .ForEach(
//            _ =>
//            {
//                if (!string.IsNullOrEmpty(_))
//                {
//                    cardNumbersAsInt.Add(int.Parse(_));
//                }
//            });
//}


int cardInteger = 1;

List<BingoCard> bingoCards = new List<BingoCard>();

for (var i = 0; i < bingoCardInput.ToArray().Length; i += 25)
{
    var card = new BingoCard(bingoCardInput.ToList().Skip(i).Take(25).ToList(), cardInteger);
    card.Print();
    bingoCards.Add(card);
    cardInteger++;
}

PlayBingo(bingoCards, puzzleInput.ToArray());


Console.WriteLine($"There are {bingoCards.Count()} bingo card(s) in play");

Console.ReadLine();

void PlayBingo(List<BingoCard> cards, int[] numbers)
{
    Console.ResetColor();
    Console.WriteLine("Lets Play BINGO");

    foreach (var number in numbers)
    {
        foreach (var card in cards)
        {
            if (card.PlayNumber(number))
            {
                WinningCard.Add(card);
            };
        }
    }
    Console.ReadLine();
     
}
