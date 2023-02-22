// Задача 5. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// using System;
// using static System.Console;

// Clear();

// int [,] GetArray()
// {
//     int[,] result = new int[4, 4];
//     int el= 0;
    
//     for (int i = 0; i < 1; i++)
//     {
//         for (int j = 0; j < 4; j++)
//         {   el=el+1;
//             result[i, j] = el;
//         }
//     break;
//     }
    
//         for (int j = 3; j < 4; j++)
//     {
//         for (int i = 1; i < 4; i++)
//         {   el=el+1;
//             result[i, j] = el;
//         }
//          break;
//     }

//     for (int i = 3; i < 4; i++)
//     {
//         for (int j = 2; j > -1; j--)
//         {   el=el+1;
//             result[i, j] = el;
//         }
//          break;
//     }

// //  for (int j = 0; j >1; j++)
// //     {
// //         for (int i = 2; i > 0; i--)
// //         {   el=el+1;
// //             result[i, j] = el;
// //         }
// //     }


//     return result;
// }



// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }
// PrintArray (GetArray());

Console.Clear();



int [,] FillImage(int [,] Array, int row, int col)
{
    if (Array[row,col] ==0)
    {  int el =0;
        Array[row,col] =el+1;
        FillImage(Array, row -1, col);
        FillImage(Array, row, col-1);
        FillImage(Array, row +1, col);
        FillImage(Array, row , col+1);
    }
    return Array;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}





int[,] Array = GetArray(4, 4);
FillImage(Array, 2, 2);
PrintArray(Array);