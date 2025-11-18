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
        }
    }
}