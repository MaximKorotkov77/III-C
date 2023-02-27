// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;
Clear();

WriteLine("Введите n");
int n = int.Parse(ReadLine());
WriteLine("Введите m");
int m = int.Parse(ReadLine());

int FindSum(int m, int n)
{
    if (m == n)
        return m;
    return (m + FindSum(m + 1, n));
}

Write($"{FindSum(m, n)}");