namespace Constructors;

    internal class Program{
      static void Main(string[] args)
    {
            Program program = new Program(); 
            program.Run();
    }
    
    private void Run()
    {
        QuizVraag quizvraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        Quiz quiz = new Quiz(10);

        mijnQuiz.VoegVraagToeOpIndex(0, "Wat is 2 + 2?", "4");
        mijnQuiz.VoegVraagToeOpIndex(1, "Wat is de hoofdstad van Nederland?", "Amsterdam");
        mijnQuiz.VoegVraagToeOpIndex(2, "Welke kleur krijg je als je blauw en geel mengt?", "Groen");
        mijnQuiz.VoegVraagToeOpIndex(3, "Hoeveel dagen zitten er in een week?", "7");
        mijnQuiz.VoegVraagToeOpIndex(4, "Wat is het tegenovergestelde van warm?", "Koud");

        
        QuizVraag vraag5 = new QuizVraag("Wat is de hoofdstad van Frankrijk?", "Parijs");
        mijnQuiz.VoegVraagToeOpIndex(5, vraag5);

        QuizVraag vraag6 = new QuizVraag("Hoeveel poten heeft een spin?", "8");
        mijnQuiz.VoegVraagToeOpIndex(6, vraag6);

        QuizVraag vraag7 = new QuizVraag("Wat is de grootste planeet in ons zonnestelsel?", "Jupiter");
        mijnQuiz.VoegVraagToeOpIndex(7, vraag7);

        QuizVraag vraag8 = new QuizVraag("Welke taal spreken ze in Brazilië?", "Portugees");
        mijnQuiz.VoegVraagToeOpIndex(8, vraag8);

        QuizVraag vraag9 = new QuizVraag("Wat is de hoofdstad van België?", "Brussel");
        mijnQuiz.VoegVraagToeOpIndex(9, vraag9);

        Console.WriteLine("Alle 10 vragen zijn toegevoegd!");

        quiz.VoegVraagToeOpIndex(0, quizvraag);
        
        for (int i = 0; i < 10; i++)
        {
            mijnQuiz.StelVraag(i);
        }

        int score = mijnQuiz.BerekenScore();
        Console.WriteLine("Je score is: " + score + " van de 10");
    }

    
}