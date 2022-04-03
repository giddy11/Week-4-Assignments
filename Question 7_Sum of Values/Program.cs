// See https://aka.ms/new-console-template for more information

static int SumOfValues(int number)
{
    if (number == 0) return 0;
    else return number + SumOfValues(number - 1);
}
Console.Write("Enter your input number: ");
int num = int.Parse(Console.ReadLine());

if (num < 0) Console.WriteLine("Number has to be positive");
else Console.WriteLine($"The sum of the integers less than or equal to {num} is {SumOfValues(num)}.");
