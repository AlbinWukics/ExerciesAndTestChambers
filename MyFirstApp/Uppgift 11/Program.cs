//UPPGIFT 11
//string[] numberLetter = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

//var input = int.Parse(Console.ReadLine());

//for (int i = 0; i < numberLetter.Length; i++)
//{
//	if (input == i)
//	{
//		Console.WriteLine(numberLetter[i]);
//	}
//}


//UPPGIFT 11, EXTRA UTMANING
//Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror,
//om man skriver in t.ex 432 så svarar programmet: “fyra-tre-två”.
string[] numberLetter = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    Console.Write(numberLetter[int.Parse(input[i] +"")]);       //Konverterar input (siffra) till int, för att använda som index
                                                                //till arrayen. Index efter input för att ta ut rätt siffra i input.
                                                                //+ "" pga felkod "kan vara null" på int.Parse(input).
    if (i != (input.Length - 1))
    {
        Console.Write("-");
    }
}

