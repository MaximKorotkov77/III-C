// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
int c = int.Parse(Console.ReadLine());

if(a>=b && a>=c)
{
Console.WriteLine($"{a}, {b}, {c} -> {a}");
return;
}
if(b>=a && b>=c)
{
Console.WriteLine($"{a}, {b}, {c} -> {b}");
return;
}
if(c>=a && c>=b)
{
Console.WriteLine($"{a}, {b}, {c} -> {c}");
return;
}