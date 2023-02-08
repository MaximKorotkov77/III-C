// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine());

int SUM(int num)
{
int d = 1;
int sum = 0;
int re = num;
while(re >10)
    {   
    re = num/d;
    sum = sum + num/(10*d) - 10*(num/(100*d));
    d = d*10;
    }
    return sum;
}
int E = SUM(n);
Console.WriteLine($"{E + n %10}");