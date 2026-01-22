using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace ProductenLaden;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
        program.RunProducten();
        program.Afspraak();

    }

    internal void Afspraak()
    {
        string text = File.ReadAllText("Afspraak.json");
        Afspraak[] afspraak = JsonSerializer.Deserialize<Afspraak[]>(text);

        foreach (Afspraak a in afspraak)
        {
            Console.WriteLine(a.Dag);
            Console.WriteLine(a.Maand);
            Console.WriteLine(a.Jaar);
        }
    }

    internal void RunProducten()
    {
        string text = File.ReadAllText("Producten.json");
        Product[] producten = JsonSerializer.Deserialize<Product[]>(text);

        foreach (Product p in producten)
        {
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Description);
            Console.WriteLine(p.Price);
        }
            
    }
    internal void Run()
    {
        string text = File.ReadAllText("Product.json");
        Product product = JsonSerializer.Deserialize<Product>(text);

        Console.WriteLine(product.Name);

        Console.WriteLine(product.Description);
        Console.WriteLine(product.Price);

    }
}

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

}

public class Afspraak
{
    public int Dag { get; set; }
    public string Maand {get; set; }
    public int Jaar { get; set; }
}
