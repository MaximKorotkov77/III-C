// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся
//  на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
int [,] matrix = new int [4,4];

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

void SumArray (int [,] matrix)
{
    int sum = 0;
for (int i =0; i<matrix.GetLength(0); i++)
{
        if(i == j)
        {
        sum += matrix[i,j];
        }
}
Console.WriteLine(sum);
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
FillArray(matrix);
PrintArray (matrix);
Console.WriteLine();

SumArray(matrix);
