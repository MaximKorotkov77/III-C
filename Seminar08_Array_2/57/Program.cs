// /* **Задача 57:**Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3,4, 6, 1, 2, 1, 6
// 1,1,1,2,2,3,4,6,6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза*\

Console.Clear();
int [,] matrix = new int [4,4];


void FindArray (int [,] matrix)
{
    int array [] = new int [matrix.GetLength(0)*matrix.GetLength(k)];
   for (int k =0; k<matrix.GetLength(0)*matrix.GetLength(k); k++)
   {

for (int i =0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {   
        int array [k] = matrix[i,j];
    }
Console.WriteLine(array);
}
}
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

FindArray (matrix);

PrintArray (matrix);