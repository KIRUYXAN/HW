int a = 21;
int b = 5;
int r = a;

a = b;
b = r;
Console.WriteLine($"{a} {b}");

(a, b) = (b, a);
Console.WriteLine($"{a} {b}");