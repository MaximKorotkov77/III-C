// **Задача 48:** Задайте 
// двумерный массив размера m на n, каждый элемент
//  в массиве находится по формуле: A[i][j] = i + j. 
//Выведите полученный массив на экран.

// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();
int [,] matrix = new int [3,4];

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

void FillArray (int [,] matrix)
{
for (int i =0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = i+j;
    }
}
}

FillArray(matrix);
PrintArray (matrix);