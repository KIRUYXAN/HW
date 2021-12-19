//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организовать в центре экрана.

static void Print(string msg, int x, int y)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine(msg);
}

string n = "Кирилл";
string sn = "Потемкин";
string c = "Москва";

Print("{sn} {n} {c}", 50, 50);
