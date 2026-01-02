using System;

namespace function;

class Program
{
    string[] vragen = new string[]
    {
        "What 1997 N64 vaideo game feature James Bond and is named after the 1995 film?",
        "What arcade game was named Puckman in Japan?",
        "If you can still remember, what are your funniest childhood memories?",
        "What would you do if you won a million dollars?"
    };
    internal string GetVraag(int vraagIndex)
    {
        return vragen[vraagIndex];
    }

    internal string GetRandomVraag()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, vragen.Length);
        return GetVraag(randomIndex);
    }
    internal void Vraag1()
    {
        Console.WriteLine("Hoe long do you think you'd survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void Vraag2()
    {
        Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void Vraag3()
    {
        Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void Vraag4()
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void Vraag5()
    {
        Console.WriteLine("What is the worst game you played but that you liked anyway?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal void Vraag6()
    {
        Console.WriteLine("Why do round pizzas come in square boxes?");
        string antwoord = Console.ReadLine();

        Console.WriteLine(antwoord);
    }

    internal string Vraag7()
    {
        Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();

        return antwoord;
    }
    static void Main(string[] args)
    {
        Program program = new Program(); 
        program.Run(); 
    }

    internal void Run()
    {
        Console.WriteLine("Dit is nu de start van mijn programma");
        Vraag1();
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();
        Vraag6();

        string antwoord7 = Vraag7();
        Console.WriteLine(antwoord7);

        string vraag0 = GetVraag(0);
        Console.WriteLine(vraag0);

        string randomVraag = GetRandomVraag();
        Console.WriteLine(randomVraag);

        AskRandomQuestion();
        AskRandomQuestion();
        AskRandomQuestion();
        AskRandomQuestion();
    }

    internal void AskRandomQuestion()
    {
        string deVraag = GetRandomVraag();
        Console.WriteLine(deVraag);
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
}
