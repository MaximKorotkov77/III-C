// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string numbers = Console.ReadLine();

int [] GetArray(string num)

{
    string[] nums = num.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int FindPos(int [] arr)
{
    int pos =0;
    foreach(int el in arr)
    {pos+= el>0 ? 1 : 0;}
    return pos;
}

int [] arr1 = GetArray(numbers);

Console.WriteLine($"[{String.Join(", ", arr1)}] -> {FindPos(arr1)}");