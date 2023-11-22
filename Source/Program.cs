
namespace RadioConformanceTests;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Q to quit..");
        while (Console.ReadKey().Key != ConsoleKey.Q);

        Environment.Exit(0);
    }
}
