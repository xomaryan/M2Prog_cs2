namespace Lists;

class Program
{
    internal List<string>charactersList = new List<string>();
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    private void Run()
    {
        string[] characters = {"Pac-Man","Samus","Crash Bandicoot","Spyro the Dragon",
        "Donkey Kong","Mario","Luigi","Astro","Solid Snake","Master Chief","Kratos","Sonic the Hedgehog","Link"
        };

        foreach (string character in characters)
        {
            Console.WriteLine(character);
        }
        
       
        charactersList.Add("Minjon");
        foreach (string characterList in charactersList)
        {
            Console.WriteLine(characterList);
        }
       
       
       

        
    }
}
