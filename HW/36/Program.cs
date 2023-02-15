// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int [] FillArray(int n)
{   
    int [] array = new int [n];
        for(int i =0; i<n; i++)
    {
        array [i] = new Random().Next(-100, 100);
    }
    return array;
}
int [] arr1 = FillArray(6);

int FINDoddSUM( int []arr)
{ int oddsum = 0;
    for (int i = 1; i< arr.Length; i+=2)
    {
        oddsum = oddsum + arr[i];
    }
return oddsum;
}


Console.WriteLine($"[{String.Join(", ", arr1)}]");
Console.WriteLine ();
Console.WriteLine($"[{String.Join(", ", FINDoddSUM( arr1))}]");
