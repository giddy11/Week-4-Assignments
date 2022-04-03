// See https://aka.ms/new-console-template for more information

static int Stringlength(string str)
{
    while (str != "")
    {
        return Stringlength(str.Substring(1)) + 1;
    }
    return 0;
}
Console.Write("Input a word or sentence: ");
string characters = Console.ReadLine();

Console.WriteLine(Stringlength(characters));
