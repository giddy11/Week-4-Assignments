// See https://aka.ms/new-console-template for more information

static void PrintPrimeNumbers(int start, int end)
{
    if (start > end) return;
    else
    {
        List<int> factors = new List<int>();
        for (int i = 1; i <= end; i++)
        {
            if ((start % i) == 0) factors.Add(i);
        }
        if (factors.Count < 3) Console.Write($"{start}, ");             //Print Prime numbers with less than 3 counts

        PrintPrimeNumbers(start + 1, end);
    }
}
Console.WriteLine("Enter your range of values to print out all Prime Numbers ");
Console.Write("From: ");
int from = int.Parse(Console.ReadLine());

Console.Write("To: ");
int to = int.Parse(Console.ReadLine());

if (from >= to) Console.WriteLine(@"""From"" has to be less than ""To""!!!");
PrintPrimeNumbers(from, to);