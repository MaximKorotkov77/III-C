﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while (i<length)
    {
        collection[i] = new Random().Next(1,10);
        i++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position =0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int findn)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == findn)
        {
            position = index;
        break;
        }
        index++;    
    }
    return position;
}

int [] array = new int[20];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 3);

Console.WriteLine(pos);