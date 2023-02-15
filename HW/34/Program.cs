// Задача 34: Задайте массив заполненный
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

int [] arr1 = FillArray(10);

int FINDEVEN (int [] arr)
{ 
    int even = 0;
    foreach (int el in arr) 
{
    even += el %2 ==0 ? 1 : 0;
}

return even;
}

FINDEVEN (arr1);

Console.Write($"[{String.Join(", ", arr1)}]");
Console.Write ($" -> {FINDEVEN (arr1)}");