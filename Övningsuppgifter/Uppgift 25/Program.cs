//Uppgift 25

//Skriv en ny klass som motsvarar en bil.
//Den ska ha privata fields för modell, pris och färg.
//Skapa publika properties för att hämta eller ändra värdet på varje field.

//Skriv en konstruktor till bilklassen som inte tar några parametrar.
//Skriv en till konstruktor som tar en parameter för varje property som klassen har.
//Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?

//Skriv en metod till bilklassen med namnet HalfPrice. När den anropas ska priset på bilen sänkas till hälften.


using Uppgift_25;

var audiA3 = new Car("Audi",300000,"Nardo grå");
var audiA1 = new Car();
audiA1.Pris = 150000;

Console.WriteLine(audiA3.Pris);
Console.WriteLine(audiA1.Pris);

audiA3.Pris = audiA3.HalfPrice("Audi A3");
audiA1.Pris = audiA1.HalfPrice("Audi A1");

Console.WriteLine(audiA3.Pris);
Console.WriteLine(audiA1.Pris);



    

