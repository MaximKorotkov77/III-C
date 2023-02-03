
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>arg1) result = arg2;
    if(arg3>arg2) result = arg3;
    return result;
}

int [] array = {1,2,3,4,5,6,7,8,9};
int max = Max ( Max(array[0], a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(max);