using System;

namespace function
{
        internal class Program
    {
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
    }
}