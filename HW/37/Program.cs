// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

Console.Clear();

int [] FillArray(int n)
{   
    int [] array = new int [n];
        for(int i =0; i<n; i++)
    {
        array [i] = new Random().Next(100);
    }
    return array;
}
int [] arr1 = FillArray(21);

int [] FillSum(int [] A)
{   int b_size = A.Length / 2;
    int [] B = new int [b_size];
    for (int i = 0; i<b_size; i++)
    {
        B [i] = A[i] + A[A.Length-1-i];
    }
    return B;
}
int [] arr2 = FillSum(arr1);
Console.WriteLine($"[{String.Join(", ", arr1)}]");
Console.WriteLine ();
Console.WriteLine($"[{String.Join(", ", arr2)}]");