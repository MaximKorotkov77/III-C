// Могут ли отрезки а, в, с быть треугольником?

Console.Clear();
Console.Write("Введите стороны треугольника через пробел: ");
string [] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int a = int.Parse(st[0]), b = int.Parse(st[1]), c = int.Parse(st[2]);

bool IsTriangle(int a, int b, int c)
{
    return ((a+b > c) && (c+b > a) && (c+a > b));
}

if (IsTriangle(a, b, c))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
