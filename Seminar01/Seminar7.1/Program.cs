﻿// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число ");
int a = int.Parse(Console.ReadLine());
if (a>99 && a<1000)
{
    Console.Write($"последняя цифра: {a%10}");
}
else
{
     Console.Write("не трехзначное число");
}