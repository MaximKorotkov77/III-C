// **Задача 53:** Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
Console.Clear();
int [,] matrix = new int [4,4];
int a = 1;
int b = 3;

void ChangeArray (int [,] matrix, int a, int b)
{
int rowCount = matrix.GetLength(0) -1;
for (int i =0; i<matrix.GetLength(1); i++)
{
         int change = matrix[a-1, i];
        matrix[a -1,i] = matrix[b -1,i];
     matrix[b -1,i] = change;
}
}
void FillArray (int [,] matrix)
{
for (int i =0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(10);
    }
}
}
void PrintArray (int [,] matrix)
{
for (int i =0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}
}

FillArray (matrix);
PrintArray (matrix);
Console.WriteLine();

ChangeArray (matrix, a, b);

PrintArray (matrix);