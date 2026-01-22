namespace _03_removeInLoop;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    internal void Run()
    {
        List<Pickup> pickups = new List<Pickup>();
        for (int i=0; i<10; i++)
        {
            Pickup pickup = new Pickup()
            {
                x = i,
                y = i,
                id = i
            };
            pickups.Add(pickup);
        }
        //foreach (Pickup pickup in pickups)
        //{
        //    if(pickup.x == 4)
        //    {
        //        pickups.Remove(pickup);
        //    }
        //}

        for (int i = pickups.Count - 1; i >= 0; i--)
        {
            if (pickups[i].x == 4)
            {
                pickups.RemoveAt(i);
            }
        }
        pickups.Reverse();

        foreach (var p in pickups)
        {
            Console.WriteLine($"pickups {p.id} is still there");
        }
            
        

    }
    class Pickup
    {
        internal int x, y;
        internal int id;
    }
}
