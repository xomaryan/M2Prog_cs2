namespace Constructors;

    internal class Program{
      static void Main(string[] args)
    {
            Program program = new Program(); 
            program.Run();
    }
    private void Run()
    {
        QuizVraag quizVraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");
        quizVraag quiz = new Quiz(10);
        quiz.VoegVraagToeopIndez(0, quizVraag);
    }

    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldenAnwoorden = new string[aantalVragen];
    }

    internal QuizVraagAntwoord(QuizVraag vraag )
    {
        vraag = vraag;
        goed = false;
    }

    
}