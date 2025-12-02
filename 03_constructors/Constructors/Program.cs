namespace Constructors;

private void Run()
{
    
    QuizVraag quizvraag = new QuizVraag("hier komt de vraag", "hier komt het antwoord");

    Quiz quiz = new Quiz(10);

    quiz.VoegVraagToeOpIndex(0, quizVraag);
    quiz.VoegVraagToeOpIndex(0,9);
}
