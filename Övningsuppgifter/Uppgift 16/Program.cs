//UPPGIFT 16
//Gör om uppgift 6 så man kan mata in allt på en rad (första talet, operator, andra talet). 
//Ignorera inmatade mellanslag i strängen. 
//Om man t.ex. matar in strängen “34 - 14”, så ska programmet skriva ut "= 20”.

//UPPGIFT 6
//Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, *eller /.Därefter ska ytterligare ett tal efterfrågas. 
//Programmet ska fungera som en simpel miniräknare. 
//Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut “3 * 5 = 15”.


//spara problemet i en sträng
//gå igenom strängen
//när operatortecknet hittas, spara det.
//spara siffrorna innan som siffra1
//spara siffrorna efter som siffra2
class Program
{
    static void Calculator()
    {
        string input;
        string operators = "+-*/";
        char op = ' ';
        int opIndex = 0;
        string siffra1 = String.Empty;
        string siffra2 = String.Empty;
        double result = 0;

        Console.WriteLine("Detta är en simpel miniräknare, på en rad, mata in siffra, operator och sista siffran.");
        input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
	        if (operators.Contains(input[i]))
	        {
		        op = input[i];
		        opIndex = i;
	        }
        }

        for (int i = 0; i < input.Length; i++)
        {
	        if (opIndex > i)
	        {
		        siffra1 += input[i];
	        }
	        else if (opIndex < i)
	        {
		        siffra2 += input[i];
	        }
        }

        switch (op)
        {
            case '+':
                result = double.Parse(siffra1) + double.Parse(siffra2);
                break;

            case '-':
                result = double.Parse(siffra1) - double.Parse(siffra2);
                break;

            case '*':
                result = double.Parse(siffra1) * double.Parse(siffra2);
                break;

            case '/':
                result = double.Parse(siffra1) / double.Parse(siffra2);
                break;

            default:
                Console.WriteLine("Ogiltligt");
                break;
        }
        Console.WriteLine(result);
    }

    static void Main(string[] args)
    {
        Calculator(); 
    }
}

