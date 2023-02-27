// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;
Clear();

WriteLine("Введите n");
int n = int.Parse(ReadLine());
int g = 1;

string PrintNumbers(int g, int n)
{
    if (g == n)
    {
        WriteLine($"{g}");
        return g.ToString();
    }
    string s = PrintNumbers(g + 1, n) + " " + g.ToString();
    WriteLine(s);
    return s;
}

PrintNumbers(g, n);

