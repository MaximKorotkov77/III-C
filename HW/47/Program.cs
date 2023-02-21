// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите кол-во столбцов");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во строк");
int n = int.Parse(Console.ReadLine());

double [,] GetArray(int m, int n)
{
    double [,] newArray = new double [m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
        newArray [i,j] = new Random().NextDouble()*(20) - 10;
        }
    }
    return newArray;
}

void PrintArray(double [,] array)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
        Console.Write($"{array[i,j] :f2} ");
        }
        Console.WriteLine();
    }
}

PrintArray(GetArray(m, n));
