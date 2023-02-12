// Упорядочить массив.

Console.Clear();
int [] array = {1, 3, 5, 6, 7, 7, 9};
void PRINT(int [] arr)
{   
    int count = arr.Length;
    for (int i = 0; i< count; i++){
    Console.Write($"{arr[i]} ");
    }
}


void SELECTION (int [] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        int minPosition = i;
        for (int j = i+1; j<arr.Length; j++)
        {
            if (array [j] < array[minPosition])
            {minPosition = j;}
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PRINT(array);
Console.WriteLine();
SELECTION(array);