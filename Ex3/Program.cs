﻿Console.WriteLine("Введи x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"{r:F2}");