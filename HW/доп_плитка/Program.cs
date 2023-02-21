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


int [,] TypeArray(int m)
{
    Console.WriteLine("Введите эл-ты массива");
    int [,] newArray = new int [m,m];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<m; j++)
        {
        newArray [i,j] = int.Parse(Console.ReadLine());
        }
    }
    return newArray;
}

void PrintArray(int [,] array)
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


// int [,] DesignArray( int [,] array)
// {
// int [,] B = new int [array.GetLength(0)-1, array.GetLength(0)-1];
// for (int i=0; i<B.GetLength(0);i++)
// {
//     for (int j=0; j<B.GetLength(0);j++)
//     {
//              B[i,j] = array[i,j]*array[i+1,j];
//     }
// }
// return B;
// }

bool DesignArray( int [,] A)
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

int [,] array = TypeArray(m);
PrintArray(array);
Console.WriteLine();
// int [,] arrayB = DesignArray(array);
// PrintArray(arrayB);
if (DesignArray(array))
{Console.WriteLine("yes");}
else
{Console.WriteLine("no");}


