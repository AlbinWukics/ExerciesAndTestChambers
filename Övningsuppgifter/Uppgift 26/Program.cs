//Skapa en klass som kan användas som stegräknare.
//Den ska ha en property Steps som bara går att läsa;
//en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
//och en metod Reset() som nollställer räknaren.

//Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.

var counter = new StepCounter();

while (counter.Steps < 1000)
{
    counter.Step();
    Console.WriteLine(counter.Steps);
}
