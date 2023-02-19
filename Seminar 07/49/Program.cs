// **Задача 49:** Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные,
//   и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 2 3 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4
// 1 **4** 3 **16**

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

void QwaterArray (int [,] matrix)
{
for (int i =0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        if (i %2 !=0 && j %2 !=0)
        matrix[i,j] = matrix[i,j] * matrix[i,j] ;
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
FillArray(matrix);
PrintArray (matrix);
Console.WriteLine();

QwaterArray (matrix);
PrintArray (matrix);