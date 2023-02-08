// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33] 

Console.Clear();
int l = 8;

int [] ARRAY(int n)
{
int [] array = new int [n];
for(int i=0; i<n; i++)
{
    array[i] = new Random().Next(50);
}
return array;
}
int [] array8 = ARRAY(l);
Console.WriteLine($"[{String.Join(", ", array8)}]");