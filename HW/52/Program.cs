// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Введите кол-во столбцов");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во строк");
int n = int.Parse(Console.ReadLine());

int [,] GetArray(int m, int n)
{
    int [,] newArray = new int [m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
        newArray [i,j] = new Random().Next(10);
        }
    }
    return newArray;
}

void PrintArray(int [,] array)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
        Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void AVE(int [,] arr)
{   Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j=0; j<arr.GetLength(1); j++)
    {
    double sum =0;
    for (int i=0; i<arr.GetLength(0); i++)
    {
        sum = sum + arr[i, j];
    }
       Console.Write($"{sum/arr.GetLength(0)} ");
    }
}

int [,] array = GetArray(m, n);


PrintArray(array);
AVE(array);