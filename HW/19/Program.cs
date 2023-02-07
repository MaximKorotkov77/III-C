// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());

int n1 = num %10;
int n10 = num/10 - 10*(num/100);
int n1000 = num/1000 -10*(num/10000);
int n10000 = num / 10000;

if (n1 == n10000 && n10 == n1000)
Console.WriteLine($"{num} -> да");
else
Console.WriteLine($"{num} -> нет");