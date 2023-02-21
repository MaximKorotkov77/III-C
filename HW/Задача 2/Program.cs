// Задача 2: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] MultArray(int [,] A, int [,] B)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = A[i,j] * B[i,j];
        }
    }
    return result;
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

int[,] arrayA =  GetArray(m, n);
PrintArray(arrayA);
WriteLine();

int[,] arrayB =  GetArray(m, n);
PrintArray(arrayB);
WriteLine();

int[,] result =  MultArray(arrayA, arrayB);
PrintArray(result);
