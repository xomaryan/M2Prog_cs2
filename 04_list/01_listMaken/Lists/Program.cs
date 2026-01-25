using System.Linq.Expressions;

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
        string[] characters = new string[]
        {
            "Pac-Man",
            "Samus",
            "Crash Bandicoot",
            "Spyro the Dragon",
            "Donkey Kong",
            "Mario",
            "Luigi",
            "Astro",
            "Solid Snake",
            "Master Chief",
            "Kratos",
            "Sonic the Hedgehog",
            "Link"
        };

        List<string> charactersList = new List<string>();
        charactersList.Add("Pikachu");
        for (int i = 0; i < characters.Length; i++)
        {
            charactersList.Add(characters[i]);
        }
        for ( int i = 0; i < charactersList.Count; i++)
        {
            Console.WriteLine(charactersList[i]);
        }
        foreach (string character in charactersList)
        {
            Console.WriteLine(character);
        }
    }
}
