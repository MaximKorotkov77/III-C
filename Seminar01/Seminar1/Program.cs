// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.Clear();
Console.Write("Ввкдите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Квадрат числа ({number} равен {sqr}");