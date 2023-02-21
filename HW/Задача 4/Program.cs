// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.

// массив размером 2 x 2 x 2
// int[,,]

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

using System;
using static System.Console;

Clear();
Write("Введите количество рядов массива: ");
int l = int.Parse(ReadLine());
Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

int[,,] GetArray(int m, int n, int l)
{
    int[,,] result = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             for (int k = 0; k < l; k++)
             {
                result[i, j, k] = new Random().Next(10, 100);
             }
        }

    }
    return result;
}


void CheckData(int[,,] inArray)
{
    int el = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    { 
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                if (inArray[i,j,k] == el)
                {
                    inArray[i,j,k] = new Random().Next(10, 100);
                }
                el =  inArray[i,j,k];
                Write($"{el} -> ({i}, {j}, {k})  ");
            }   WriteLine();
        } 
        
    }
    
}

int[,,] Array = GetArray(m, n, l);
CheckData(Array);
