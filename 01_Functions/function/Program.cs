using System;

namespace function
{
        internal class Program
    {
        string[] vragen = new string[]{
            "What 1997 N64 vaideo game feature James Bond and is named after the 1995 film?",
            "What arcade game was named Puckman in Japan?"
        };
        

        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }

        internal string GetRandomVraag()
        {
            Random random = new Random();
            int random1 = random.Next(vragen.Length);
            return GetVraag(random1);
        }
        

        static void Main(string[] args)
        {
            Program program = new Program(); //Variable van type Program is program.    //Program() is function constructor.
            program.Run(); //HIer roep ik met Run().  //Run is een functie.   //Return type is void.
        }

        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma.");
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            string antwoord7 = Vraag7();
            Console.WriteLine(antwoord7);
            string vraag0 = GetVraag(0);
            Console.WriteLine(vraag0);
            string randomVraag = GetRandomVraag(); 
            Console.WriteLine(randomVraag); 
            
        }

        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);

        }

        internal void Vraag2()
        {
            Console.WriteLine("What would you do if you won a milion dollars?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag3()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord1 = Console.ReadLine();

            Console.WriteLine(antwoord1);
        }

        internal void Vraag4()
        {
            Console.WriteLine("Have you ever tried talking to animals?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag5()
        {
            Console.WriteLine("Has someone caught you dancing in front of the mirror?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal string Vraag7()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            return antwoord;

        }
        
    }
}