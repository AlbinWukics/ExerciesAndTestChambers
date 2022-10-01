//Fråga användaren hur många tal den vill mata in.
//Fråga sedan efter talen i tur och ordning (“Ange tal 1:” osv).
//När alla tal är inmatade skriv ut dem i omvänd ordning.

//Console.WriteLine("Hur många tal vill du mata in?");
//int arraySize = int.Parse(Console.ReadLine());
//string[] numbers = new string[arraySize];


//for (int i = 0; i < arraySize; i++)
//{
//    Console.WriteLine($"Ange tal {i+1}");
//    numbers[i] = Console.ReadLine();
//}

//Console.WriteLine("\n\n");

//for (int i = numbers.Length-1; i >= 0; i--)
//{
//    Console.WriteLine(numbers[i]);
//}



//Fråga användaren hur många tal den vill mata in.
//Fråga sedan efter talen i tur och ordning (“Ange tal 1:” osv).
//När alla tal är inmatade skriv ut dem i omvänd ordning.

Console.WriteLine("Hur många tal vill du mata in?");
int arraySize = int.Parse(Console.ReadLine());

string[] numbersArray = new string[arraySize];

for (int i = 0; i < numbersArray.Length; i++)
{
    Console.WriteLine($"Mata in tal {i+1}.");
    numbersArray[i] = Console.ReadLine();
}

Console.WriteLine("\n\n");

for (int i = numbersArray.Length-1; i >= 0; i--)
{
    Console.WriteLine(numbersArray[i]);
}