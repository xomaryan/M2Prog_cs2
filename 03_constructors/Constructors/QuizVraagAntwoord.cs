using System.Data;
using System.Runtime.CompilerServices;

class QuizVraagAntwoord
{
    
    internal QuizVraag vraag;
    internal bool goed;

    
    internal QuizVraagAntwoord(QuizVraag deVraag)
    {
        this.vraag = deVraag;
        this.goed = false;
    }
}
