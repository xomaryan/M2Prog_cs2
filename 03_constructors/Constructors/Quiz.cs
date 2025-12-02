class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldenAntwoorden;

    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }
    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        
    }
}
