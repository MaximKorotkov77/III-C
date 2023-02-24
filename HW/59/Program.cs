// 59
// Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен первый найденный наименьший элемент.

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

int Findmin_i (int [,] inArray)
{ int min = inArray[0,0];
    int min_i = 0;
    int min_j = 0;
    for (int i =0; i<inArray.GetLength(0);i++)
    {
        for (int j =0; j<inArray.GetLength(1);j++)
        {
            if (min>inArray[i,j])
            {
                 min = inArray[i,j];
                 min_i = i;
                
            }
           
        }
    }
    return min_i;
    
}

int Findmin_j (int [,] inArray)
{ int min = inArray[0,0];
    int min_i = 0;
    int min_j = 0;
    for (int i =0; i<inArray.GetLength(0);i++)
    {
        for (int j =0; j<inArray.GetLength(1);j++)
        {
            if (min>inArray[i,j])
            {
                 min = inArray[i,j];
               
                 min_j = j;
            }
           
        }
    }
    
    return min_j;
}


int[,] ChangeArray(int[,] inArray, int min_i, int min_j)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)-1];
    for (int i = 0; i < result.GetLength(0); i++)
    { 
             
        for (int j = 0; j < result.GetLength(1); j++)
         {  
            
            if (j >= min_j) 
            {
                result[i, j] = inArray[i,j+1];
             }
            
            else
            {
            result[i, j] = inArray[i,j];
            }
         
        }
    }

        int[,] result2 = new int[result.GetLength(0)-1, result.GetLength(1)];
        for (int j = 0; j < result2.GetLength(0); j++)
        { 
             
        for (int i = 0; i < result.GetLength(1); i++)
         {  
            if (i >= min_i) 
            {
                 result2[i, j] = result[i+1,j];
            }
                  
            else
            {
            result2[i, j] = result[i,j];
            }
         
        }

    }
    return result2;
}


int [,] Array= GetArray(m, n);
PrintArray(Array);
WriteLine();
int min_i = Findmin_i(Array);
int min_j = Findmin_j(Array);
WriteLine($"{min_i} {min_j}");
WriteLine();
ChangeArray(Array, min_i, min_j);
PrintArray(ChangeArray(Array, min_i, min_j));


