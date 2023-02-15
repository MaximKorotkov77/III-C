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
int [] array = new int [N];  или такой __array__
int n = array.Length; __array__ __length__
Console.WriteLine($"[{String.Join(", ", array)}]"); __вывод массива__

int[] array = new int [n];
for (int i = 0; i<n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

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

switch (x)  __switch__
{
    case 1:
    {
        Console.WriteLine("x>0 && y>0");
        break;
    }
      default:
    {
        Console.WriteLine("type 1 2 3 4");
        break;
    }}
                                                                    __Math.Sqrt__
    double dist = Math.Sqrt((x1 -x2)*(x1 -x2) + (y1 -y2)*(y1 -y2));  __корень__
    double dist = Math.Sqrt(Math.Pow(x1 -x2, 2) __степень__
    Console.WriteLine($"dist={dist:f3}") __округление __три знака после запятой__

for (int i = 0; i < n; i++) __цикл for__

n += ; // __n = n+1__
n /= 10; // __n = n/10__
n *= (-1);  // __n = -1*n__
n *= i;// __n = n*i__

foreach (int el in array) // [1,2,5,7,9] __foreach__
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}

string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); // __Split__ - разбивает строку в массив

string [] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); 
int a = int.Parse(st[0]), b = int.Parse(st[1]), c = int.Parse(st[2]); // __Split__ - __int через строку в терминале__

int[] GetArrayFromString(string stringArray) // __Split__ задача 33. __Ввод массива через строку в терминале.__
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int[] array, int el)//[1,2,3,4] 5 __bool__ Задача 33 __Выводит 1 или 0, да или нет__
{
    foreach (var item in array)//
    {
        if (el == item) // 5 == 4
            return true; 
    }
    return false;
}

bool IsTriangle(int a, int b, int c) __bool__ Задача 40 __Выводит 1 или 0, задача на да или нет__
{
    return ((a+b > c) && (c+b > a) && (c+a > b));
}