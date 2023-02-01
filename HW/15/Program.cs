// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру дня недели: ");
int day = int.Parse(Console.ReadLine());
if(day>1 && day<6)
Console.WriteLine($"{day} -> нет");
else if (day>5 && day<8)
Console.WriteLine($"{day} -> да");
else 
Console.WriteLine($"{day} -> не день недели");