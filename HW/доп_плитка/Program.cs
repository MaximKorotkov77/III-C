// *Доп1
// На днях Иван у себя в прихожей выложил кафель,
// состоящий из квадратных черных и белых плиток.
// Прихожая Ивана имеет квадратную форму 4х4, вмещающую 16 плиток.
// Теперь Иван переживает, что узор из плиток, который у него получился,
// может быть не симпатичным. С точки зрения дизайна симпатичным узором считается тот,
// который не содержит в себе квадрата 2х2, состоящего из плиток одного цвета.
// Входные данные:
// BWBW
// BBWB
// WWBB
// BWWW
// Ответ:
// Yes

// Входные данные:
// BBWB
// BBWB
// WWBW
// BBWB
// Ответ:
// No


Console.Clear();

Console.WriteLine("Введите размер массива");
int m = int.Parse(Console.ReadLine());


char[,] TypeArray(int m)
{
    Console.WriteLine("Введите эл-ты массива");
    char [,] newArray = new char [m,m];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<m; j++)
        {
        newArray [i,j] = char.Parse(Console.ReadLine());
        }
    }
    return newArray;
}

void PrintArray(char [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
        Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


bool DesignArray( char [,] A)
{
for (int i=0; i<A.GetLength(0)-1;i++)
{
    for (int j=0; j<A.GetLength(0)-1;j++)
    {
             if(A[i,j] == A[i+1,j] && A[i,j] == A[i,j+1] && A[i,j] == A[i+1,j+1])
             {
             return true;
             break;
             }
    }
}
return false;
}

char [,] array = TypeArray(m);
PrintArray(array);
Console.WriteLine();

if (DesignArray(array))
{Console.WriteLine("ответ: yes");}
else
{Console.WriteLine("ответ: no");}
