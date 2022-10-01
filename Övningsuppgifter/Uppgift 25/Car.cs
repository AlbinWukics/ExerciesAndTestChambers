namespace Uppgift_25;

//Skriv en ny klass som motsvarar en bil.
//Den ska ha privata fields för modell, pris och färg.
//Skapa publika properties för att hämta eller ändra värdet på varje field.

//Skriv en konstruktor till bilklassen som inte tar några parametrar.
//Skriv en till konstruktor som tar en parameter för varje property som klassen har.
//Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?

//Skriv en metod till bilklassen med namnet HalfPrice. När den anropas ska priset på bilen sänkas till hälften.


public class Car
{
    private string _modell;
    public string Modell
    {
        get { return _modell; }
        set { _modell = value; }
    }

    private int _pris;
    public int Pris
    {
        get { return _pris; }
        set { _pris = value; }
    }

    private string _färg;
    public string Färg
    {
        get { return _färg; }
        set { _färg = value; }
    }

    public Car()
    {

    }

    public Car(string modell, int pris, string färg)
    {
        Modell = modell;
        Pris = pris;
        Färg = färg;
    }

    public void HalfPrice()
    {
        Console.WriteLine($"Halva priset på bilen är: {Pris / 2}");
    }
}