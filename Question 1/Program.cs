// See https://aka.ms/new-console-template for more information

static double Factorial(double number)
{
    double fact;
    while (number != 0)
    {
        return fact = number * Factorial(number - 1);       
    }
    return 1;
}
Console.Write("Enter Number to calculate for factorial: ");
int num = int.Parse(Console.ReadLine());

if (num < 0) Console.WriteLine("Number has to be greater or equal to zero.");
else Console.WriteLine(Factorial(num));