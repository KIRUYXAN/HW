/*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
где m — масса тела в килограммах, h — рост в метрах.*/

Console.WriteLine("Давайте вычеслим ваш ИМТ");
Console.WriteLine("Введите ваше вес в кг:");
double m = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вашу рост в см: ");
double h = Convert.ToDouble(Console.ReadLine()) / 100;
Console.WriteLine(" ");
double imt = m / (h * h);

Console.WriteLine($"Ваш ИМТ: {imt:F2}");