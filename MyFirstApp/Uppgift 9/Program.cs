//UPPGIFT 9
//Skriv ett program som frågar användaren efter ett tal mellan 1 och 100.
//Programmet ska ha ett hemligt tal lagrat i en variabel.
//Det ska fortsätta fråga användaren till dess att användaren gissar det hemliga talet.
//Om man gissade för högt eller för lågt så ska det skrivas ut, så att användaren har en rimlig chans att klara det.
//Exempel: programmet har det hemliga talet 27. Användaren gissar på 50.
//Programmet skriver ut att användaren gissade för högt. Användaren gissar på 20.
//Programmet skriver ut att det var för lågt. Användaren gissar på 27.
//Programmet skriver ut att det var rätt och avslutas.

//EXTRA UTMANING 1 + UPPGIFTEN

//Random random = new Random();
//var randomNr = random.Next(1, 100);
//Console.WriteLine("Gissa siffran mellan ett och hundra");

//while (true)
//{
//    if (int.TryParse(Console.ReadLine(), out var input))
//    {
//        if (input == randomNr)
//        {
//            Console.WriteLine("Gratulerar, du gissade rätt!");
//            Console.WriteLine("Tryck för att avsluta.");
//            Console.ReadKey(true);
//            break;
//        }
//        else if (input < randomNr)
//        {
//            Console.WriteLine("Du gissade för lågt.");
//        }
//        else
//        {
//            Console.WriteLine("Du gissade för högt.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Fel format, mata in siffra mellan 1-100.");
//    }
//}

//EXTRA UTMANING 2
//skriv ett sten-sax-påse spel. Användaren skriver in “sten”, “sax” eller “påse”.
//Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omgången.
//Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något).
//Skriv även ut poäng.

Random random = new Random();
var pointsComp = 0;
var pointsMe = 0;

while (true)
{
    Console.WriteLine("Välj sten, sax eller påse. Slå GLaDOS eller förbi försökskanin resten av ditt patetiska liv.");
    var randomNr = random.Next(1, 4);
    var input = Console.ReadLine();
    
    if (input == "sten")
    {
        if (randomNr == 1)
        {
            Console.WriteLine("Du valde sten, GLaDOS valde sten.");
        }
        else if (randomNr == 2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Du valde sten, GLaDOS valde sax. Ett poäng till dig!");
            Console.ForegroundColor = ConsoleColor.White;
            pointsMe++;
        }
        else if (randomNr == 3)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Du valde sten, GLaDOS valde påse. Ett poäng till GLaDOS!");
            Console.ForegroundColor = ConsoleColor.White;
            pointsComp++;

        }
    }
    else if (input == "sax")
    {
        if (randomNr == 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Du valde sax, GLaDOS valde sten. Ett poäng till GLaDOS!");
            Console.ForegroundColor = ConsoleColor.White;
            pointsComp++;
        }
        else if (randomNr == 2)
        {
            Console.WriteLine("Du valde sax, GLaDOS valde sax.");
        }
        else if (randomNr == 3)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Du valde sax, GLaDOS valde påse. Ett poäng till dig!");
            Console.ForegroundColor = ConsoleColor.White;
            pointsMe++;
        }
    }
    else if (input == "påse")
    {
        if (randomNr == 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Du valde påse, GLaDOS valde sten. Ett poäng till dig!");
            Console.ForegroundColor = ConsoleColor.White;

            pointsMe++;

        }
        else if (randomNr == 2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Du valde påse, GLaDOS valde sax. Ett poäng till GLaDOS!");
            Console.ForegroundColor = ConsoleColor.White;
            pointsComp++;

        }
        else if (randomNr == 3)
        {
            Console.WriteLine("Du valde påse, GLaDOS valde påse. ");
        }
    }
    else if (input == "")
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input.");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    Console.WriteLine("Du har: "+pointsMe+" poäng."+"\n"+"GLaDOS har: "+pointsComp+" poäng.");
    Console.WriteLine("Tryck för att fortsätta.");
    Console.ReadKey(true);
    Console.Clear();
}
