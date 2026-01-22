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
        List<Mob> mobs = new List<Mob>();
        for (int i = 0; i < 3; i++)
        {
            mobs.Add(new Mob());
        }

        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            foreach (Mob mob in mobs)
            {
                int kans = random.Next(0, 100);
                if (kans < 30)
                {
                    mob.TakeDamage(1);
                }
            }
        }

        List<Mob> defeated = mobs.Where(mob=>mob.isDead).ToList();
        Console.WriteLine(defeated.Count);
    }
}

class Mob
{
    internal bool isDead;
    internal int hp = 10;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            isDead = true;
        }
    }
}
