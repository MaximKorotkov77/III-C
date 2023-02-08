//30 Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]

Console.WriteLine("Введите число элеметов массива");
int n = int.Parse(Console.ReadLine());

int [] ARRA( int N)
{
    int [] array = new int [n]; 
for(int i=0; i<N; i++){
    array [i] = new Random().Next(2);
   }
   return array;
}
int[] array0 = ARRA(n);
Console.WriteLine($"[{String.Join(", ", array0)}]");