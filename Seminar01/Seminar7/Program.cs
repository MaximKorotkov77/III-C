// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n > 99 || n < 1000)
{
int b = n%10;
 Console.WriteLine($"{b}");
}
else
{
Console.WriteLine($"не то");
}