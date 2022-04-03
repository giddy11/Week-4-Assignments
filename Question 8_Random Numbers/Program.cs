// See https://aka.ms/new-console-template for more information

static void PrintRandomSelectedNumbers(int lowerNumber, int upperNumber)
{
    Random rnd = new Random();
    List<int> randomNumbers = new List<int>();
    int repeatedNumber = rnd.Next(lowerNumber, upperNumber);
    int counter = 1;

    while (!randomNumbers.Contains(repeatedNumber) && counter > 0)
    {
        Console.WriteLine(repeatedNumber);
        randomNumbers.Add(repeatedNumber);
        repeatedNumber = rnd.Next(lowerNumber, upperNumber);
        counter++;

        Console.ReadKey();
    }

    Console.WriteLine($"{repeatedNumber}");
    Console.WriteLine($"It took {counter} Itterations to repeat {repeatedNumber}");
}
Console.Write("Enter the range of values: \n");
Console.Write("From: ");
int begin = int.Parse(Console.ReadLine());
Console.Write("To: ");
int end = int.Parse(Console.ReadLine());

PrintRandomSelectedNumbers(begin, end);