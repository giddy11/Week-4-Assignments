// See https://aka.ms/new-console-template for more information

static void NumbersToWords(int number)
{
    string[] ones = {"Zero", "one","two","three","four","five","six","seven","eight","nine","ten",
                 "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen",
                 "eighteen","nineteen"};

    string[] tenss = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    if (number < 20) Console.WriteLine(ones[number]);
    else if (number >= 20 && number < 100)
    {
        int unit = number % 10;
        int tens = number / 10;
        string result = tenss[tens - 2] + (unit > 0 ? "-" + ones[unit] : "");
        Console.WriteLine(result);
    }
    else Console.WriteLine("One Hundred");
}
Console.Write("Input a number from 1-100: ");
int num = int.Parse(Console.ReadLine());

if (num > 100) Console.WriteLine("Number has to be from 1-100");
else NumbersToWords(num);