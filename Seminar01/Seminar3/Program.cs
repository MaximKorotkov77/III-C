// SЗадача №3. Напишите программу, 
// которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Clear();
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
 Console.WriteLine($"число {num}");


if (n == 1)
{
       Console.WriteLine($"{n} -> понедельник");
}
else if (n == 2)
{
    Console.WriteLine($"{n} -> вторник");
}
else if (n == 3)
{
    Console.WriteLine($"{n} -> среда");
}
else if (n == 4)
{
    Console.WriteLine($"{n} -> четверг");
}
else if (n == 5)
{
    Console.WriteLine($"{n} -> пятница");
}
else if (n == 6)
{
    Console.WriteLine($"{n} -> суббота");
}
else if (n == 7)
{
    Console.WriteLine($"{n} -> воскресенье");
}
else {
    Console.WriteLine(" не бывает");
}