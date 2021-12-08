Console.WriteLine("Давайте сделаетм для вас анкету.");
Console.WriteLine("Введите ваше имя: ");
string n = Console.ReadLine();
Console.WriteLine("Введите вашу фамилию: ");
string sn = Console.ReadLine();
Console.WriteLine("Введите ваш возраст(только цифры): ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваш рост в см(только цифры): ");
string h = Console.ReadLine();
Console.WriteLine("Введите ваш вес в кг(только цифры): ");
string w = Console.ReadLine();
if (age == 1)
{
	Console.WriteLine($@"Вот ваша анкета:
	ФИО: {sn} {n}
	Возраст: {age} год
	Рост: {h} см
	Вес: {w} кг");
}
else if ((bool)(age == 2)||(bool)(age == 3)||(bool)(age == 4))
{
	Console.WriteLine($@"Вот ваша анкета:
	ФИО: {sn} {n}
	Возраст: {age} года
	Рост: {h} см
	Вес: {w} кг");
}
else 
{
	Console.WriteLine($@"Вот ваша анкета: 
	ФИО: {sn} {n} 
	Возраст: {age} лет 
	Рост: {h} см 
	Вес: {w} кг");
}