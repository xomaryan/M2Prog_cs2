namespace Rijschool;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        Program Run();
    }

    //Auto function
    Auto auto1 = new Auto()
    {
        automaat = true,
        kenteken = "AA824H",
        kilometerStand = 20567,
        merk = "Volkswagen"
    };

    Auto auto2 = new Auto()
    {
        automaat = false,
        kenteken = "KU786G",
        kilometerStand = 65739,
        merk = "Volvo"
    };


    //RijLeraar function
    RijLeraar rijLeraar = new RijLeraar()
    {
        leeftijd = 30,
        naam = "John",
        zzp = false,
    };

    //Lesuur functions
    LesUur lesUur1 = new LesUur()
    {
        auto = auto1,
        rijLeraar = rijLeraar,
        tijd = 1130,
    };

    LesUur lesUur2 = new LesUur()
    {
        auto = auto2,
        rijLeraar = rijLeraar,
        tijd = 2245,
    };

    //Student function
    Student student1 = new Student()
    {
        naam = "Maks",
        leeftijd = 17,
        lesPakket = lesPakket1,
        leraar = leraar,
        theorieTest = theorieTest,
        rijTest = rijTest,
    };

    //LesPakket function
    LesPakket lesPakket1 = new LesPakket()
    {
        urenGekocht = 1,
        urenVerbruikt = 2,
        examenPogingen = 3,
        automaat = false,
    };
    Dag dag = new Dag()
    {
        datum = datum,
        leuren[0],
    };

}
