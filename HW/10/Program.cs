// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
while((a<100) || (a>1000))
{
    Console.WriteLine("неверное число, введите трехзначное");
    a = int.Parse(Console.ReadLine());
}
 Console.WriteLine($"{a} -> {a/10 - 10*(a/100)}"); 