namespace _02_Remove;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    internal void Run()
    {
        List<double> reviews = new List<double>() {9.99, 4.68, 342.97, 12.2};

        reviews.Remove(342.97);
        reviews.RemoveAt(0);
        foreach (double review in reviews)
        {
            Console.WriteLine(review);
            
        }
        
    }
}
