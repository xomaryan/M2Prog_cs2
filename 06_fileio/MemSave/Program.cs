namespace MemSave;

class Program
{
    string welkomstTekst = "hello World";
    string saveFile = "welkomState.txt";
    static void Main(string[] args)
    {  
        Program program = new Program();
        program.Run();  
    }

    internal void Run()
    {
        if (File.Exists(saveFile))
        {
            welkomstTekst = File.ReadAllText(saveFile);
        }

        while (true)
        {
            Console.WriteLine(welkomstTekst);
            string invoer = Console.ReadLine();

            if (invoer.Length > 0)
            {
                welkomstTekst = invoer;
                File.WriteAllText(saveFile, welkomstTekst);
            }
        }
    }

    
}
