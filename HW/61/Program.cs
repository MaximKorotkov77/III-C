// 61
// Показать треугольник Паскаля. 
// *Сделать вывод в виде равнобедренного треугольника.

using System;
using static System.Console;

Clear();

WriteLine("Введите размер массива");
int m = int.Parse(ReadLine());

int[,] GetArray(int m)
{
    int[,] result = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = 0;
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

int[,] TryArray(int [,] inArray)
{
    int [,] result = inArray;
    inArray[0, m/2] = 1;
    // inArray[0, 0] = 1;
    
    for (int i = 1; i < m; i++)
    {
        for (int j = 1 ; j < m; j++)
        {
             result[i, j] = result[i-1, j] + result[i-1, j-1];
           
        }
    }
    return result;
}


int [,] Array = GetArray(m);
int [,] Array2 = TryArray(Array);
PrintArray(Array);
WriteLine();
PrintArray(Array2);