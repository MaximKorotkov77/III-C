// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int MULT(int a)
{
    int result = 1;
        for (int i =1; i<=N; i++ )
        
    {
        result *= i;
        
    }
    return result;
}
Console.WriteLine($"{MULT(N)}");