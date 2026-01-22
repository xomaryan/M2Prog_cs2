namespace Filelo;

class Program
{
    internal void Run()
    {
        Console.WriteLine(Environment.CurrentDirectory);
        string[] lines = File.ReadAllLines("quiz.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine(Environment.CurrentDirectory);
        string[] lines2 = File.ReadAllLines("quiz1.txt");
        foreach (string line in lines2)
        {
            Console.WriteLine(line);
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
}
