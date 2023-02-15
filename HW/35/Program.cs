// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

Console.Clear();

int [] FillArray(int n)
{   
    int [] array = new int [n];
        for(int i =0; i<n; i++)
    {
        array [i] = new Random().Next(1001);
    }
    return array;
}

int [] arr1 = FillArray(123);

int FINDQ (int [] arr)
{
int find = 0;
foreach(int el in arr)
{
    find += el>9 && el <100 ? 1 : 0;
}

return find;
}
FINDQ (arr1);

Console.WriteLine($"[{String.Join(", ", arr1)}]");
Console.WriteLine ();
Console.WriteLine ($" -> {FINDQ (arr1)}");