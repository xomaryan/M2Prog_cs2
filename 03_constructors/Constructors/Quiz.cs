class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldenAntwoorden;

    internal Quiz(int aantalVragen, int ingevulden)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldenAntwoorden = new QuizVraagAntwoord[ingevulden];
    }

    internal void VoegVraagToeopIndex( int index, QuizVraag vraag )
    {
        vragen[index] = vraag;

    }
    internal void VoegVraagToeopIndex1(int index, string vraag, string antwoord)
    {
        vragen[index] = vraag;
    }

}
