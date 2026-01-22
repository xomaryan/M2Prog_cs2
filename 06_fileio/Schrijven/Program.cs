using System.Net.Security;
using System.Text.Json;

namespace Schrijven;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        FavoriteGame[] favoriteGames = new FavoriteGame[]
        {
            new FavoriteGame { Name = "PUBG Mobile", Platform ="PC"},
            new FavoriteGame { Name = "Minecraft", Platform ="PC"},
            new FavoriteGame { Name = "Fortnite", Platform ="PC"}
        };
        string jsonText = JsonSerializer.Serialize<FavoriteGame[]>(favoriteGames);
        File.WriteAllText("game.json", jsonText);

        File.WriteAllText("mijntext.txt", "Dit is een text");
        foreach (FavoriteGame game in favoriteGames)
        {
            Console.WriteLine(game.Name);
            Console.WriteLine(game.Platform);
        }
        string[] regels =
        {
            "Dit is regel 1",
            "Dit is regel 2",
            "Dit is regel 3"
        };

        File.WriteAllLines("mijntext2.txt", regels);
    }
}
public class FavoriteGame
{
    public string Name { get; set; }
    public string Platform {get; set;} 
}
