namespace Constructors;

    internal class Program{
      static void Main(string[] args)
    {
            Program program = new Program(); 
            program.Run();
    }
    
    internal void Run()
    {
        QuizVraag quizvraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        Quiz quiz = new Quiz(10);

        quiz.VoegVraagToeOpIndex(0, quizvraag);

        quiz.VoegVraagToeOpIndex(0, "Wat is 2+2?", "4");
        quiz.VoegVraagToeOpIndex(1, "Welke kleur is gras?", "Groen");
        quiz.VoegVraagToeOpIndex(2, "Hoeveel poten heeft een spin?", "8");
        quiz.VoegVraagToeOpIndex(3, "Wat is de hoofdstad van Nederland?", "Amsterdam");
        quiz.VoegVraagToeOpIndex(4, "Wie is de hulp van Sinterklaas?", "Piet");
        quiz.VoegVraagToeOpIndex(5, "Hoe heet de planeet waar we op wonen?", "Aarde");
        quiz.VoegVraagToeOpIndex(6, "Welk dier zegt 'Woef'?", "Hond");
        quiz.VoegVraagToeOpIndex(7, "Wat is de kleur van een banaan?", "Geel");
        quiz.VoegVraagToeOpIndex(8, "Hoeveel vingers heeft een mens?", "10");

        QuizVraag laatsteVraag = new QuizVraag("Is dit de laatste vraag?", "Ja");
        quiz.VoegVraagToeOpIndex(9, laatsteVraag);

        for (int i = 0; i < 10; i++)
        {
            quiz.StelVraag(i);
            Console.WriteLine();
        }

        int eindScore = quiz.BerekenScore();
        Console.WriteLine("--------------------");
        Console.WriteLine("DE quiz is klaar!");
        Console.WriteLine("Jouw totale score is: " + eindScore + " van de 10!");
        Console.WriteLine("--------------------");

    }

    
}