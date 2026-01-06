namespace Dictionaries;

class Program
{
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
    }
}
