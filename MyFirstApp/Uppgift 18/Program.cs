////UPPGIFT 18
////Be användaren mata in en mening.
////Skriv ut det genomsnittliga antalet bokstäver i orden.

//class Program
//{
//    static void Main(string[] args)
//    {
//        int numbersOfSpaces = 0;
//        int letters = 0;
//        int result = 0;
//        string words = String.Empty;
//        string input = String.Empty;
//        string spaces = " !?.";

//        Console.WriteLine("Mata in en sträng med meningar.");
//        input = Console.ReadLine();

//        for (int i = 0; i < input.Length; i++)
//        {
//            //om det finns mellanslag, punkt, utropstecken...
//            if (spaces.Contains(input[i]))
//            {
//                //lägger till antal bokstäver per ord
//                words += letters;
//                letters = 0;
//                //Sparar hur många mellanslag, punkter och utropstecken det finns.
//                numbersOfSpaces++;
//            }
//            else
//            {
//                //sparar antal bokstäver.
//                letters++;
//            }
//        }

//        //addera siffrorna i strängen words för att få ut antalet bokstäver
//        //dela antalet bokstäver för att få ut medelvärde
//        for (int i = 0; i < words.Length; i++)
//        {
//            Console.WriteLine("antal ord");
//        }

//        Console.WriteLine(words);
//        Console.WriteLine(numbersOfSpaces);
//    }
//}






//UPPGIFT 18
//Be användaren mata in en mening.
//Skriv ut det genomsnittliga antalet bokstäver i orden.

class Program
{
    static void Main(string[] args)
    {
        int numbersOfSpaces = 0;
        double letters = 0;
        string input = String.Empty;
        string spaces = " !?.,";

        Console.WriteLine("Mata in en sträng med meningar. Glöm inte avsluta med punkt annars jävlar.");
        input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (spaces.Contains(input[i]))
            {
                numbersOfSpaces++;
            }
            else
            {
                letters++;
            }
        }

        
        Console.WriteLine("Antal bokstäver: "+letters);
        Console.WriteLine("Antal mellanslag, utropstecken osv...: "+numbersOfSpaces);
        letters /= numbersOfSpaces;
        Console.WriteLine("Medelvärde för antal bokstäver per ord: "+letters);
    }
}