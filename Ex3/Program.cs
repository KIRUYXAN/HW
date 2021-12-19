//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
//по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
//Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

static double stepen(double a, double atimes)
{
    for (int i = 1; i < atimes; i++)
        return a * a;
    return atimes = Convert.ToDouble("");
}
static double root(double n, double times)
{
    if (times == 2)
        n = Math.Sqrt(n);
    if (times == 3)
        n = Math.Cbrt(n);
    return n;
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

double rm = root(stepen(x2 - x1, 2) + stepen(y2 - y1, 2), 2);
Console.WriteLine($"{rm:F2}");