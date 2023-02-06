// Принимает на вход N. Выдает таблицу квадратов от 1 до N
// Массив вводим и выводим
Console.Clear();
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());

int i = 1;
int m =N; // m=-10;

if (N<0)
{
    i = N;
    m = -N;
    N =-1;
}

int [] result = new int [m];
for(int j=0; i<=N; i++)
{
    result[j] = i*i;
    j++;
    }

for(int j=0; i<m; j++)
{
    Console.Write($"{result[j]} ");
}