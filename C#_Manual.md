dotnet new console

Console.Clear();

Console.Write("Введите текст: ");

int number = int.Parse(Console.ReadLine ());  // переводит тип __string__ из термила в тип __int__

Console.WriteLine($"Квадрат числа {number} равен {sqr}"); // переводит текст в переменные ($"Текст {int} текст {int}");