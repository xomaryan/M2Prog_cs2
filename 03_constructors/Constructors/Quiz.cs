class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldenAntwoorden;

    internal Quiz(int aantalVragen, int ingevulden)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldenAntwoorden = new QuizVraagAntwoord[ingevulden];
    }

}