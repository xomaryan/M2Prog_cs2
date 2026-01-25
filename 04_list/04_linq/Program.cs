using System.Linq;

namespace _04_linq;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        List<Mob> mobs = new List<Mob>()
        {
            new Mob(){name = "orc"},
            new Mob(){name="goblin"},
            new Mob(){name="troll"}
        };

        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            foreach (Mob mob in mobs)
            {
                int getal = random.Next(100);
                if (getal < 10)
                {
                    mob.TakeDamage(1);
                }
            }
        }

        List<Mob> defeated = mobs.Where(mob=>mob.isDead).ToList();

        foreach (Mob mob in defeated)
        {
            Console.WriteLine("A mob was defeated! " + mob.name);
        }
        Console.WriteLine(defeated.Count);
    }
}

class Mob
{
    internal bool isDead;
    internal int hp = 10;
    internal string name;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            isDead = true;
        }
    }
}
