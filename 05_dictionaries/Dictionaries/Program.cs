using System.Runtime.InteropServices.Marshalling;

namespace Dictionaries;

class Program
{
    Dictionary<string, Room> rooms = new Dictionary<string, Room>();
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int,string>(); // Ik heb een lege dictionary gemaakt

        personeelOpNummer.Add(382942, "jim");  // Ik voeg een item toe aan de dictionary
        personeelOpNummer.Add(789432, "tim");

        string jim = personeelOpNummer[382942];  // Ik haal een item op uit de dictionary
        Console.WriteLine(jim);   // Dit print in de console "jim"

        string tim = personeelOpNummer[789432];
        Console.WriteLine(tim);

        foreach (KeyValuePair<int, string> item in personeelOpNummer) //Loop door dictionary
        {
            string naam = item.Value;   // Haal de waarde op uit het item
            int personnelOpNummer = item.Key;   // Haal de key op uit het item
            Console.WriteLine(personnelOpNummer + ": " + naam);  // Print key en value samen
        }

        foreach (int key in personeelOpNummer.Keys)  // Loop door alle keys in de dictionary
        {
            Console.WriteLine(key);
        }

        foreach (string value in personeelOpNummer.Values)   // Loop door alle values in dictionary
        {
            Console.WriteLine(value);
        }  

        Room start = new Room(0, 0, [
            "xxxxx",
            "x   x",
            "x   x",
            "x   x",
            "xxxxx"
        ]);
        rooms.Add(start.GetRoomLocationKey(), start);

        Room start2 = new Room(0, 1, [
            "xxxxx",
            "x   x",
            "x   x",
            "x   x",
            "xxxxx"
        ]);
         rooms.Add(start2.GetRoomLocationKey(), start2);
        
        Room start3 = new Room(1, 1, [
            "xxxxx",
            "x   x",
            "x   x",
            "x   x",
            "xxxxx"
        ]);
        rooms.Add(start3.GetRoomLocationKey(), start3);

        Room start4 = new Room(1, 0, [
            "xxxxx",
            "x   x",
            "x   x",
            "x   x",
            "xxxxx"
        ]);
        rooms.Add(start4.GetRoomLocationKey(), start4);

        ShowRoom(0, 0);
        ShowRoom(0, 1);
        ShowRoom(1, 1);
        ShowRoom(1, 0);
        ShowRoom(2, 0);
    }
    private void ShowRoom(int x, int y)
    {   
        bool hasRoom = rooms.ContainsKey($"{x}, {y}");

        if (hasRoom)
        {
            Room room = rooms[$"{x}, {y}"];
            
            Console.WriteLine($"You are in room {x}, {y}");
            foreach (string r in room.level)
            {
                Console.WriteLine(r);
            }
        }
        else
        {
            Console.WriteLine("Error room does not exist");
        }
        
    }
}

class Room
{
    internal int x, y;
    internal string[] level;

    internal Room(int x, int y, string[] level)
    {
        this.x = x;
        this.y = y;
        this.level = level;
    }

    internal string GetRoomLocationKey()
    {
        return $"{x}, {y}";
    }
}



