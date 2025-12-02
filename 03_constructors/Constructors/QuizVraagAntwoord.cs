class QuizVraagAntwoord
{
    internal QuizVraagAntwoord vraag;
    internal bool goed;

    internal QuizVraagAntwoord(QuizVraag vraag)
    {
        vraag = vraag;
        goed = false;
    }
}