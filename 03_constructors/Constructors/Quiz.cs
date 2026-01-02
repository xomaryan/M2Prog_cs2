class Quiz
{
    internal QuizVraagAntwoord[] vragen;
    internal string[] ingevuldenAntwoorden;

    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraagAntwoord[aantalVragen];
        ingevuldenAntwoorden = new string[aantalVragen];
    }

    internal void VoegVraagToeOpIndex(int index, QuizVraag deVraag)
    {
        vragen[index] = new QuizVraagAntwoord (deVraag);
    }

    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag nieuweVraag = new QuizVraag(vraag, antwoord);
        VoegVraagToeOpIndex(index, nieuweVraag);    
    }

    internal void StelVraag(int index)
    {
        QuizVraagAntwoord huidige = vragen[index];
        Console.WriteLine(huidige.vraag.vraag);

        string antwoordVanSpeler = Console.ReadLine();
        ingevuldenAntwoorden[index] = antwoordVanSpeler;
        if (antwoordVanSpeler == huidige.vraag.antwoord)
        {
            Console.WriteLine("Goed gedaan!");
            huidige.goed = true;
        }
        else
        {
            Console.WriteLine("Hellas...");
            huidige.goed = false;
        }
        ingevuldenAntwoorden[index] = antwoordVanSpeler;
    }

    internal int BerekenScore()
    {
        int score = 0;
        for (int i = 0; i < vragen.Length; i++)
        {
            if (vragen[i].goed == true)
            {
                score = score +1;
            }
        }
        return score;
    }
    }
   
