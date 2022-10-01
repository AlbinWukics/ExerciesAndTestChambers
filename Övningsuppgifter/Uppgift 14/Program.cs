//UPPGIFT 14
//Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *


//LÖSNING 1
//char[] vokaler = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

//string inputText = Console.ReadLine();

//bool write = true;

//for (int i = 0; i < inputText.Length; i++)
//{
//    for (int j = 0; j < vokaler.Length; j++)
//    {
//        if (inputText.ToLower()[i] == vokaler[j])
//        {
//            Console.Write("*");
//            //ERSÄTT VOKALER MED STJÄRNA
//            write = false;
//            break;
//        }
//    }
//    if (write == true)
//    {
//        Console.Write(inputText[i]);
//    }
//    write = true;
//}



//LÖSNING 2
//char[] textVol = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

////string vokaler = "aeiouyåäö";         //Alternativ till ovanstående var

//string text = Console.ReadLine();

//foreach (char a in textVol)
//{
//    text = text.ToLower().Replace(a, '*');
//}
//Console.WriteLine(text);



//Extra utmaning: Skriv ut texten översatt till rövarspråket.

//LÖSNING 1
//char[] konsonanter = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'z', 'x' };

//Console.WriteLine("Mata in en text så översätter jag den till rövarspråk");
//string input = Console.ReadLine();

//bool write = true;

//for (int i = 0; i < input.Length; i++)
//{
//	for (int j = 0; j < konsonanter.Length; j++)
//	{
//		if (input.ToLower()[i] == konsonanter[j])
//		{
//			Console.Write(konsonanter[j] + "o" + konsonanter[j]);
//			write = false;
//			break;
//		}
//	}
//	if (write == true)
//	{
//		Console.Write(input[i]);
//	}
//	write = true;
//}



//LÖSNING 2
char[] konsonanter = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'z', 'x' };
Console.WriteLine("Mata in en text så översätter jag den till rövarspråk");
string input = Console.ReadLine();
string result = string.Empty;

for (int i = 0; i < input.Length; i++)
{
	if (konsonanter.Contains(input[i]))
	{
		result += input[i] + "o";
	}
	result += input[i];
}
Console.WriteLine(result);

