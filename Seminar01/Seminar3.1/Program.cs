// SЗадача №3. Напишите программу, которая будет 
//выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.Clear();
Console.Write("Введите номер дня:");
int day = int.Parse(Console.ReadLine());
if (day == 1)
{
Console.Write($"{day} -> Понедельник");
}
if (day == 2)
{
Console.Write($"{day} -> Вторник");
}
if (day == 3)
{
Console.Write($"{day} -> Среда");
}
if (day == 4)
{
Console.Write($"{day} -> Четыерг");
}
if (day == 5)
{
Console.Write($"{day} -> Пятница");
}
if (day == 6)
{
Console.Write($"{day} -> Суббота");
}
if (day == 7)
{
Console.Write($"{day} -> Воскресенье");
}
if (day >7 || day <1 )
{
Console.Write($"{day} -> нет такого дня");
}