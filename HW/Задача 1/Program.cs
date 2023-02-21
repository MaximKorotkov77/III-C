// Задача 1: Задайте двумерный массив.
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10);
        }

    }
    return result;
}

void SortArray(int[,] inArray)
{ int [,] result = new int [inArray.GetLength(0), inArray.GetLength(1)];
    for (int g = 0; g < inArray.GetLength(0); g++)
    { 
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
            for (int j = i + 1; j < inArray.GetLength(1); j++)
            {
                if (inArray[g,i] > inArray[g,j])
                {
                    int k = inArray[g,i];
                    inArray[g,i] = inArray[g,j];
                    inArray[g,j] = k;
                }
            }
        }
    }   
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int [,] array = GetArray(m, n);
PrintArray(array);
 WriteLine();
SortArray(array);
PrintArray(array);