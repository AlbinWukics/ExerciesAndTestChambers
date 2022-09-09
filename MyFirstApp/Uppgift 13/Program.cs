//UPPGIFT 13
//Be användaren mata in en text.
//Skriv sedan ut texten baklänges.

Console.WriteLine("Mata in en text, så skall jag mata ut den baklänges åt dig.");

string inputText = Console.ReadLine();

for (int i = inputText.Length-1; i >= 0; i--)
{
    Console.Write(inputText[i]);
}

