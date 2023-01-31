Console.Clear();
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

int sqr = b * b;
if (sqr == a)
{
       Console.WriteLine($"Квадрат числа ({b} равен {a}");
}
else
{
    Console.WriteLine($"Квадрат числа {b} не равен {a}");
}