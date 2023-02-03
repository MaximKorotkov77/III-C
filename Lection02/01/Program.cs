
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>arg1) result = arg2;
    if(arg3>arg2) result = arg3;
    return result;
}

int a1 =100;
int b1 =2;
int c1 =3333;
int a2 =4;
int b2 =53;
int c2 =644;
int a3 =4170;
int b3 =51;
int c3 =61;

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(max);