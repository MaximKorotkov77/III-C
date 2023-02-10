// void Method1()
// {
//     Console.Write("Автор...");
// }
// Method1();

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "текст сообщения");

// void Method21(string msg, int count)
// { int i = 0;
//     while(i<count)
//     {
//         Console.Write(msg);
//         i++;
//     }

// }
// Method21("Hi ", 5);

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year );

// string Method4(int count, string text)
// {
//     int i= 0;
//     string result = String.Empty;
//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string tex = Method4(15, "Hello");
// Console.Write(tex);

string Method4(int count, string text)
{
    int i= 0;
    string result = String.Empty;
    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string tex = Method4(15, "Hello");
Console.Write(tex);