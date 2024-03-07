static void Main(string[] args)
{
    List<int> MyNumbers = new();

    while (true)
    {
        MyNumbers.Add(GenerateNewNumber(MyNumbers, 6));
        Console.WriteLine(string.Join(", ", MyNumbers));
    }

}


static int GenerateNewNumber(List<int> myList, int MaxInt, int MinInt = 0)
{
    List<int> AllNumbers = Enumerable.Range(MinInt, MaxInt).ToList();
    AllNumbers.RemoveAll(myList.Contains);

    if (AllNumbers.Count == 0)
        throw new Exception("No new numbers can be generated in this range.");
        //return 0;
    
    return AllNumbers[new Random().Next(AllNumbers.Count())];
}
