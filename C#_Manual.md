dotnet new console

Console.Clear();

Console.Write("Введите текст: ");

int number = int.Parse(Console.ReadLine ());  // переводит тип __string__ из термила в тип __int__

Console.WriteLine($"Квадрат числа {number} равен {sqr}"); // переводит текст в переменные ($"Текст {int} текст {int}");

__if__ (day >7 || day <1 )
{
Console.Write($"{day} -> нет такого дня");
}

__while__ (b <= a)
{Console.Write($"{b}, ");
    b++;
}

123 % 10 = 3 // остаток

if (s.Length !=3) // __Length__

while(a<10 || a>0)
{Неверное число,введите заново} // циклическое условие __введите заново__

string s = Console.ReadLine();
string a = Convert.ToString(s[2]); __взять символ с индексом 2__

int num = new Random().Next(10, 100); __Random__ от 10 до 99
Console.WriteLine($"Число {num}");

int [] array = {1,2,3,4,5,6,7,8,9}; __array__
int n = array.Length; __array__ __lengt__


int Max(int arg1, int arg2, int arg3) __function__
{
    int result = arg1;
    if(arg2>arg1) result = arg2;
    if(arg3>arg2) result = arg3;
    return result;
}
int max = Max ( Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

void FillArray(int[] collection) __FillArray__
{
    int length = collection.Length;
    int i = 0;
    while (i<length)
    {
        collection[i] = new Random().Next(1,10);
        i++;
    }
}