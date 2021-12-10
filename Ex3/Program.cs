static double stepen(double a, double atimes)
{
    for (int i = 1; i < atimes; i++)
        return a * a;
    return atimes = Convert.ToDouble("");
}


Console.WriteLine("Введи x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"{r:F2}");

Console.WriteLine("");

double r1 = x2 - x1;
double r2 = y2 - y1;
double r3 = Math.Sqrt(stepen(r1, 2) + stepen(r2, 2));
Console.WriteLine($"{r3:F2}");