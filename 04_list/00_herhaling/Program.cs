namespace _04_list;

class Program
{
    double[] prijzen = new double[] { 0.99, 5.60, 10.11, 1.9 };
    string[] artiekelen = {"snoepje", "luxe broodje", "lunch menu", "milk"};
    Formulier[] formulieren = new Formulier[2];
    
    
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    
    internal class Formulier
    {
        internal int Sterren {get; set;}
        internal string FeedBack {get; set;}
    }
    private void Run()
    {
        formulieren[0] = new Formulier()
        {
            FeedBack = "prijzig maar lekker",
            Sterren = 5
        };

        formulieren[1] = new Formulier()
        {
            FeedBack = "lunch menu was erg lekker",
            Sterren = 3
        };
        foreach (Formulier formulier in formulieren)
        {
            
        }
        {
           
        }
        for (int i = prijzen.Length - 1; i >= 0; i--) 
        {
            Console.WriteLine(prijzen[i]);
            Console.WriteLine(artiekelen[i]);
        }
    }

    
}