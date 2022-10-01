//Gör ett program som ber användaren mata in en text.
//Be sedan användaren mata in en sträng som är en del av den första texten.
//Skriv ut hela texten med den del man angav markerad i en annan färg.
//Ex. Användare matar in “abcdefghijklmnopqrstuvxyz”, och sedan “defg”.
//Programmet ska då skriva ut: abcdefghijklmnopqrstuvxyz

//class Program
//{
//    static void Main(string[] args)
//    {
//        string input1;
//        string input2;
//        bool write = true;

//        Console.WriteLine("Mata in en text, sedan en till text som är en del av första texten");
//        input1 = Console.ReadLine();
//        input2 = Console.ReadLine();


//        for (int i = 0; i < input1.Length; i++)
//        {
//            for (int j = 0; j < input2.Length; j++)
//            {
//                if (input1[i] == input2[j])
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.Write(input1[i]);
//                    Console.ForegroundColor = ConsoleColor.White;
//                    write = false;
//                }
//            }
//            if (write == true)
//            {
//                Console.Write(input1[i]);
//            }
//            write = true;
//        }
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        string input1 = String.Empty;
        string input2 = String.Empty;

        Console.WriteLine("Mata in två meningar, så skall jag färglägga de som matchar");

        input1 = Console.ReadLine();
        input2 = Console.ReadLine();

        for (int i = 0; i < input1.Length; i++)
        {
            //Om indexen för input1 inhåller något från input2. Läs höger till vänster (parantes först)
            if (input2.Contains(input1[i]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(input1[i]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(input1[i]);
            }
        }
    }
}