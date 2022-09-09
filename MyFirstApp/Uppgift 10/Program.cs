//UPPGIFT 10

//Console.WriteLine("Mata in en sträng");
//var input = Console.ReadLine();

//for (int i = 0; i < input.Length; i++)
//{
//    Console.WriteLine(input[i]);
//}

//Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad. Ex: Hej => H e j

//Be användaren mata in en text och spara det i en string.
string text = Console.ReadLine();
//För varje tecken i texten.
foreach (var tecken in text)
{
	//Skriv ut tecknet på ny rad.
	Console.WriteLine(tecken);
}