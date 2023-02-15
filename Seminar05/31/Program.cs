//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

// Console.Clear();
// int l = 12;
// int max = 0;
// int min = 0;

// int [] ARRAY(int n, int min, int max)
// {
// int [] array = new int [n];
// for(int i=0; i<n; i++)
// {
//     array[i] = new Random().Next(-9, 9);
//     if (array[i] >0) 
//     {max = max + array[i];
//     }
//     else if (array[i] <0) 
//     {min = min - array[i];}
// }
// return array;
// return max;
// return min;
// }
// int [] array8 = ARRAY(l);


// Console.WriteLine($"[{String.Join(", ", array8)}]");
// Console.WriteLine($"max = {max}, min = {min}");
Console.Clear();

int[] GetRandomArray(int size,int minValue,int maxValue){  
      int[] result = new int[size];
    for (int i = 0; i < size; i++)
        result[i] = new Random().Next(minValue,maxValue+1);
    return result;
    }
int [] A = GetRandomArray(12, -9, 10);
Console.WriteLine($"[{String.Join(", ", A)}]");
int neg=0, pos=0;
for (int i=0; i<12; i++) {
    if (A[i]<0) 
        neg+=1;
    else if (A[i]>0) 
        pos+=1;
    }
Console.WriteLine($"+: {pos}");
Console.WriteLine($"-: {neg}");

foreach (int el in array) // [1,2,5,7,9] __foreach__
{
    positiveSum += el > 0 ? : 0;
    negativeSum += el < 0 ? : 0;
}