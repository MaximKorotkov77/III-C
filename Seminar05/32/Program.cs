// **Задача 32:**Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

Console.Clear();

int[] GetRandomArray(int size,int minValue,int maxValue){  
      int[] result = new int[size];
    for (int i = 0; i < size; i++)
        result[i] = new Random().Next(minValue,maxValue+1);
    return result;
    }
int [] A = GetRandomArray(12, -9, 10);
Console.WriteLine($"[{String.Join(", ", A)}]");
Console.WriteLine();

int [] NEG( int [] array)
{for (int i = 0; i<array.Length; i++){
array[i] *= (-1);
}
return array;
}
// int [] B =NEG( A);
Console.WriteLine($"[{String.Join(", ", NEG(A))}]");
