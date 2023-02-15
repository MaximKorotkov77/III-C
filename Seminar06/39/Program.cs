// Переворот массива.
Console.Clear();
Console.WriteLine("Введите эл-ты массива");
string array = Console.ReadLine();



int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int [] ThrowOver( int [] A)
{int [] B = new int [A.Length];
for (int i = 0; i<A.Length; i++)
{ B[i] = A [A.Length - 1 - i];}
return B;
}
int[] arr1 = GetArrayFromString(array);


Console.WriteLine($"[{String.Join(", ", arr1)}]");
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", ThrowOver(arr1))}]");