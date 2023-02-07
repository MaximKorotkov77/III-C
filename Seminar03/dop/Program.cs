// Посчитать количество переворотов монеток.
Console.Clear();
Console.WriteLine("Введите количество монеток: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int [n];
for (int i = 0; i<n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
int o = 0; int r = 0;
for (int i = 0; i<n; i++)
{
    if (array[i] == 0)
    {
        o++;
    }
    else {r++;}
}
if (o>r)
{Console.WriteLine($"Минимальное колличество переворотов {r}");}
if (o<r)
{Console.WriteLine($"Минимальное колличество переворотов {o}");}
