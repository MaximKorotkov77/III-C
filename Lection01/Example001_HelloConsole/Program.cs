using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter username");
        string username = Console.ReadLine();

        if (username == "Max")
        {
            Console.WriteLine("Hooray, It's Max!")
        }
        else
        {
            Console.Write("Hello, ");
            Console.WriteLine(username);
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}