// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("введите А");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("введите B");
int B = int.Parse(Console.ReadLine());
int POW(int k, int l)
{
int pow = 1;
for(int i=1; i<=l; i++)
{
   pow *=k;
}
return pow;
}
int deg = POW(A,B);
Console.WriteLine($"{deg}");