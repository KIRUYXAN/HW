Console.WriteLine("Давайте вычеслим ваш ИМТ");
Console.WriteLine("Введите ваше вес в кг:");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вашу рост в см: ");
double h = Convert.ToDouble(Console.ReadLine());
h = h / 100;
double imt = m / (h * h);
Console.WriteLine($"Ваш ИМТ: {imt:F2}");