//Skapa en klass som kan användas som stegräknare.
//Den ska ha en property Steps som bara går att läsa;
//en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
//och en metod Reset() som nollställer räknaren.


public class StepCounter
{
	private int _steps;
	//readonly genom att ta bort "set" metoden.
	//FÖR ATT man kommer alltid bara ta ett steg. Finns inget fall där man behöver komma åt Property.n och addera t.ex. 10;
	public int Steps
	{
		get { return _steps; }
	}
	public void Step()
    {
        _steps++;
    }
	public void Reset()
    {
        _steps = 0;
    }
}

