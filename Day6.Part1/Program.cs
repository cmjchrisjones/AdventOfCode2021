// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var initalLanternFishState = new List<int> { 5, 1, 1, 5, 4, 2, 1, 2, 1, 2, 2, 1, 1, 1, 4, 2, 2, 4, 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 5, 3, 1, 4, 1, 1, 1, 1, 1, 4, 1, 5, 1, 1, 1, 4, 1, 2, 2, 3, 1, 5, 1, 1, 5, 1, 1, 5, 4, 1, 1, 1, 4, 3, 1, 1, 1, 3, 1, 5, 5, 1, 1, 1, 1, 5, 3, 2, 1, 2, 3, 1, 5, 1, 1, 4, 1, 1, 2, 1, 5, 1, 1, 1, 1, 5, 4, 5, 1, 3, 1, 3, 3, 5, 5, 1, 3, 1, 5, 3, 1, 1, 4, 2, 3, 3, 1, 2, 4, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 4, 1, 3, 2, 5, 2, 1, 1, 1, 4, 2, 1, 1, 1, 4, 2, 4, 1, 1, 1, 1, 4, 1, 3, 5, 5, 1, 2, 1, 3, 1, 1, 4, 1, 1, 1, 1, 2, 1, 1, 4, 2, 3, 1, 1, 1, 1, 1, 1, 1, 4, 5, 1, 1, 3, 1, 1, 2, 1, 1, 1, 5, 1, 1, 1, 1, 1, 3, 2, 1, 2, 4, 5, 1, 5, 4, 1, 1, 3, 1, 1, 5, 5, 1, 3, 1, 1, 1, 1, 4, 4, 2, 1, 2, 1, 1, 5, 1, 1, 4, 5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 4, 2, 1, 1, 1, 2, 5, 1, 4, 1, 1, 1, 4, 1, 1, 5, 4, 4, 3, 1, 1, 4, 5, 1, 1, 3, 5, 3, 1, 2, 5, 3, 4, 1, 3, 5, 4, 1, 3, 1, 5, 1, 4, 1, 1, 4, 2, 1, 1, 1, 3, 2, 1, 1, 4 };

for (var i = 0; i < 80; i++)
{
    Console.Write($"After {i+1} day(s): ");
    bool hasNewFish = false;
    var newFishList = new List<int>();
    var newFishState = new List<int>();
    foreach (var f in initalLanternFishState)
    {
        var fValue = f;
        if (f == 0)
        {
            hasNewFish = true;
            newFishList.Add(8);
            fValue = 7;
        }
        newFishState.Add(fValue -= 1);  
    }
    initalLanternFishState.Clear();
    if (hasNewFish)
    {
        newFishState.AddRange(newFishList);
    }
    initalLanternFishState.AddRange(newFishState);
    //initalLanternFishState.ForEach(f => Console.Write($"{f},"));
    Console.WriteLine();
    Console.WriteLine($"Number of fish: {initalLanternFishState.Count}");

}

Console.ReadLine();