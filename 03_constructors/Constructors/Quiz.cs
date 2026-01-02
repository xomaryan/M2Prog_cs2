class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldenAntwoorden;

    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
    }
   public void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }
    
    public void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag nieuweVraag = new QuizVraag(vraag, antwoord);
        VoegVraagToeOpIndex(index, nieuweVraag);
    }

    public void StelVraag(int index)
{
    //  Haal de vraag op uit de array
    QuizVraag vraag = vragen[index];

    //  Maak een nieuwe QuizVraagAntwoord en koppel de vraag
    QuizVraagAntwoord antwoord = new QuizVraagAntwoord(vraag);

    //  Stel de vraag
    Console.WriteLine(vraag.VraagTekst);

    //  Lees het antwoord van de gebruiker
    string gegevenAntwoord = Console.ReadLine();

    //  Check of het goed is
    if (gegevenAntwoord == vraag.Antwoord)
    {
        antwoord.Goed = true;
        Console.WriteLine("Goed gedaan! 🎉");
    }
    else
    {
        antwoord.Goed = false;
        Console.WriteLine("Helaas, fout. Het juiste antwoord was: " + vraag.Antwoord);
    }

    //  Bewaar het antwoord op de juiste plek
    ingevuldeAntwoorden[index] = antwoord;
}
    public int BerekenScore()
{
    int score = 0;

    for (int i = 0; i < ingevuldeAntwoorden.Length; i++)
    {
        if (ingevuldeAntwoorden[i] != null && ingevuldeAntwoorden[i].Goed)
        {
            score++;
        }
    }

    return score;
}
}