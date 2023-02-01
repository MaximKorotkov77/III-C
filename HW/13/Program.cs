// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
string s = Console.ReadLine();
int min = int.Parse(s);

if (s.Length >2 && min>0)
{
string a = Convert.ToString(s[2]);
Console.WriteLine($"{s} -> {a} ");
return;
}

if (s.Length >3 && min<0)
{
string a = Convert.ToString(s[3]);
Console.WriteLine($"{s} -> {a} ");
}

else
{
Console.WriteLine($"{s} -> нет третьей цифры");
}