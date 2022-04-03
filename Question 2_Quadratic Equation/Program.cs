// See https://aka.ms/new-console-template for more information

static string FindRoots(double a = 0, double b = 0, double c = 0)
{
    double roootsFinding = Math.Pow(b, 2) - (4 * a * c);
    if (roootsFinding < 0) return "Complex roots";
    else if (roootsFinding > 0) return "Real roots";
    else return "Equal roots";
}
Console.WriteLine("The function tells you the type of root of a given quadratic equation");
Console.Write("Enter 'a' which is the coefficient of X²: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Enter 'b' the coefficient of X: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Enter the value of the constant 'C': ");
double c = double.Parse(Console.ReadLine());

Console.WriteLine(FindRoots(a, b, c));
