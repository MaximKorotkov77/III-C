// Расстояние между 2-мя точками
Console.Clear();

Console.WriteLine("Введите координату х1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату х2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y2");
int y2 = int.Parse(Console.ReadLine());

double dist = Math.Sqrt((x1 -x2)*(x1 -x2) + (y1 -y2)*(y1 -y2));
Console.WriteLine($"Расстояние {dist}");