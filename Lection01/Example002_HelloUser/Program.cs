internal class Program
{
    private static void Main(string[] args, Console console)
    {
        console.Write("Enter username");
        string username = Console.ReadLine();
        Console.Write("Hello, ");
        Console.Write(username);
    }
}