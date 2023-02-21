// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Введите кол-во столбцов");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во строк");
int n = int.Parse(Console.ReadLine());

int [,] TypeArray(int m, int n)
{
    Console.WriteLine("Введите эл-ты массива");
    int [,] newArray = new int [m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
        newArray [i,j] = int.Parse(Console.ReadLine());
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

void FindElement(int [,] array)
{
Console.WriteLine("Введите номер строки");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int n = int.Parse(Console.ReadLine());
if (m>array.GetLength(0) || n>array.GetLength(1))
{
    Console.WriteLine($"[{m},{n}] -> такого числа в массиве нет");
}
else Console.WriteLine($"[{m},{n}] -> {array[m-1,n-1]}");
}

int [,] array = TypeArray(m, n);

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FindElement(array);

