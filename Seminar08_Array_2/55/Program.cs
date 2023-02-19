// **Задача 55:**Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// В итоге получается вот такой массив:

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

Console.Clear();
int [,] matrix = new int [4,4];

int ChangeArray (int [,] matrix)
{
    int [,] changematrix = new int [matrix.GetLength(1),matrix.GetLength(0)];
if (matrix.GetLength(0) == matrix.GetLength(1))
{
for (int i =0; i<matrix.GetLength(0); i++)
{
    for (int j =0; j<matrix.GetLength(1); j++)
    {
       changematrix [i,j] = matrix[j, i];
    }
}
return changematrix;
}
else Console.WriteLine ("Невозможно");
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

ChangeArray (matrix);

PrintArray (changematrix);