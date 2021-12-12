// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var initalLanternFishState = new List<int> { 3, 4, 3, 1, 2 };
int[] newFish;

for (var i = 0; i < 80; i++)
{
    Console.Write($"After {i + 1} day(s): ");
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
    newFish = newFishList.ToArray();
    if (hasNewFish)
    {
        newFishState.AddRange(newFishList);
    }
    initalLanternFishState.AddRange(newFishState);
    //initalLanternFishState.ForEach(f => Console.Write($"{f},"));
    Console.WriteLine();

}

