//UPPGIFT 5
//int sum = 0, numberOfInputs = 0, medelvärde = 0;
//while (true)
//{
//    Console.WriteLine("Mata in tal");
//    if (int.TryParse(Console.ReadLine(), out var inputNr))
//    {
//        sum += inputNr;
//        numberOfInputs++;
//        Console.WriteLine($"Summan av dina tal är {sum}.");
//        Console.WriteLine(numberOfInputs);
//    }
//    else
//    {
//        medelvärde = sum / numberOfInputs;
//        Console.WriteLine($"Medelvärdet på dina inmatade tal är: {medelvärde}.");
//        Console.ReadKey(true);
//        break;
//    }
//}



//UPPGIFT 6
//Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, *eller /.Därefter ska ytterligare ett tal efterfrågas. 
//Programmet ska fungera som en simpel miniräknare. 
//Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut “3 * 5 = 15”.
//while (true)
//{
//    Console.WriteLine("Detta är en simpel miniräknare, vänligen mata in ett tal.");

//    if (int.TryParse(Console.ReadLine(), out var Nr1))
//    {
//        Console.WriteLine("Vill du addera, subtrahera, multiplicera eller dividera? Vänligen mata in en av följande tecken:  +  -  *  /");
//        string valtTecken = Console.ReadLine();
//        Console.WriteLine("Vänligen mata in ditt andra tal.");

//        if (int.TryParse(Console.ReadLine(), out var Nr2))
//        {

//            switch (valtTecken)
//            {
//                case "+":
//                    Console.WriteLine($"Svar: {Nr1+Nr2}");
//                    break;

//                case "-":
//                    Console.WriteLine($"Svar: {Nr1 - Nr2}");
//                    break;

//                case "*":
//                    Console.WriteLine($"Svar: {Nr1 * Nr2}");
//                    break;

//                case "/":
//                    Console.WriteLine($"Svar: {Nr1 / Nr2}");
//                    break;

//                default:
//                    Console.WriteLine("Ogiltligt valt tecken");
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Försök igen.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Försök igen.");
//    }
//}



//UPPGIFT 7
//Skriv ett program som ber användaren skriva in en månad. Programmet ska göra om månaden till månadens siffervärde.
//T.ex. ska januari bli 1 och december 12.
//Använd switch. Alternativ: Prova även att lösa uppgiften med array och/eller enum.
//MED SWITCH
//while (true)
//{
//    Console.WriteLine("Mata in en månad.");
//    string månad = Console.ReadLine().ToLower();
//    switch (månad)
//    {
//        case "januari":
//            Console.WriteLine("Januari är månad ett");
//            break;

//        case "februari":
//            Console.WriteLine("Februari är månad två");
//            break;

//        case "mars":
//            Console.WriteLine("Mars är månad tre");
//            break;

//        case "april":
//            Console.WriteLine("April är månad fyra");
//            break;
//        default:
//            Console.WriteLine("Ogiltig månad");
//            break;
//    }
//}


//UPPGIFT 7
//MED ARRAY
//string[] months = { "januari", "februari", "mars", "april", "maj", "juni" };
//foreach (var i in months)
//{
//	Console.WriteLine(i);
//}
//Console.WriteLine("Skriv in en av ovanstående månader.");
//string n = (Console.ReadLine());

////FORLOOP ALTERNATIV 1
////for (int i = 0; i < months.Length; i++)
////{
////    if (n.Equals(months[i]))
////    {
////        Console.WriteLine(i + 1);
////        break;
////    }
////}

////FORLOOP ALTERNATIV 2
//for (int i = 0; i < months.Length; i++)
//{
//	if (months[i]==n)
//	{
//		Console.WriteLine(i+1);
//	}
//}


//UPPGIFT 7 EXTRA UTMANING med ENUM, gick åt helvete
//class Program
//{
//    enum Months
//    {
//        January=1,
//        February,
//        Mars,
//        April,
//        May,
//        June,
//        July,
//        August,
//        September,
//        October,
//        November,
//        December
//    }
//    static void Main(string[] args)
//    {
//        var input1 = Console.ReadLine();
//        var input2 = Console.ReadLine();


//        Months january = Months.January;
//        Months february = Months.February;
//        Months mars = Months.Mars;
//        Months april = Months.April;

//        if (input1 == january)
//        {

//        }
//    }
//}


//UPPGIFT 7 EXTRA UTMANING, FÖRSÖK 2
//string[] months = { "", "januari", "februari", "mars", "april", "maj", "juni", "juli", "augusti", "september", "oktober", "november", "december" };
//Console.WriteLine("Mata in två månader, en i taget.");
//string input1 = Console.ReadLine();
//string input2 = Console.ReadLine();
//input1 = input1.ToLower();
//input2 = input2.ToLower();
//int month1 = 0;
//int month2 = 0;

//for (int i = 0; i < months.Length; i++)
//{
//    if (input1.Equals(months[i]))
//    {
//        month1 = i;
//        break;
//    }
//}
//for (int i = 0; i < months.Length; i++)
//{
//    if (input2.Equals(months[i]))
//    {
//        month2 = i;
//        break;
//    }
//}
//if (month1 > month2)
//{
//    month1 -= 12;
//}
//int monthDiff = month1 - month2;
//monthDiff = Math.Abs(monthDiff);

//if (monthDiff > 1)
//{
//    Console.WriteLine($"Det skiljer sig {monthDiff} månader mellan {input1} och {input2}.");
//}
//else
//{
//    Console.WriteLine($"Det skiljer sig {monthDiff} månad mellan {input1} och {input2}.");
//}
