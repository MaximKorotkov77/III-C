﻿// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int [] FillArray(int n)
{   

    int [] array = new int [n];
        for(int i =0; i<n; i++)
    {
        array [i] = new Random().Next(100, 1000);
    }
    return array;
}
FillArray(6);
// int ODD(int [] arr)
// {
//      for(int i =0; i<arr.Length; i++)
     
//     {int odd = 0;
//          if(arr[i] %2==0)
//          {
//              odd = odd +1;
//          }
//         return odd;
//     }
    
// }
int [] arr = FillArray(6);
     for(int i =0; i<6; i++)
     {
     
    int odd = 0;
         if(arr[i] %2==0)
         {
             odd = odd +1;
         }
  return odd;
     }
Console.WriteLine($"[{String.Join(", ", FillArray(6))}]");
Console.WriteLine();
// Console.WriteLine($"{ODD(FillArray(6))}");
Console.WriteLine($"[{odd}");