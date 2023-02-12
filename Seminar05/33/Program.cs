/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет

3; массив[6, 7, 19, 345, 3]->да*/

Console.Clear();
int [] ENT_AR(int n){
int[] array = new int[n];
for(int i =0; i<n; i++)
{
    
    Console.WriteLine("Введите эл-ты массива");
    array[i]= int.Parse(Console.ReadLine ());
   }
   return array;
}

Console.WriteLine("Введите число");
int find = int.Parse(Console.ReadLine ());


void FIND(int [] ENT, int f)
{
    for(int i =0; i<ENT.Length; i++)
{
    if (ENT [i] == f) 
    Console.WriteLine("да");
    else
    Console.WriteLine("нет");
   }
}

int [i] array = ENT_AR(5);
FIND(array, find);