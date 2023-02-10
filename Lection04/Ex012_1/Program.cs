// See https://aka.ms/new-console-template for more information
Console.Clear();
for (int i = 2; i<11; i++)
{
    for (int j = 2; j<11; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
