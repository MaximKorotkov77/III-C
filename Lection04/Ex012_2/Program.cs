string s = "Для установки перемычки на клемме должен быть разъем(гнездо),"
+"Т.е. перемычку IZUK можно установить в клемму WGO1 с кодами 3.70591,"
+" 3.70592, 3.70593 В клемму WGO1 3.70590 установить перемычку ";

string Replace(string text, char oldvalue, char newvalue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i=0;i<length;i++)
    {
        if(text[i] == oldvalue) 
        result = result + $"{newvalue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(s, ' ', '|' );
Console.Write(newText);