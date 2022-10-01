//Ett palindrom är ett ord som blir samma framlänges som baklänges. 
//Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.

Console.WriteLine("Mata in ett ord så anger jag om det är ett palidrom eller ej.");
string input = Console.ReadLine();

string inputRev = String.Empty; 

for (int i = input.Length - 1; i >= 0; i--)
{
    inputRev += input[i];
}

if (input.ToLower() == inputRev.ToLower())
{
    Console.WriteLine("Ditt ord är ett palidrom");
}
else
{
    Console.WriteLine("Ditt ord är ej ett palidrom");
}
Console.WriteLine(input + " " + inputRev);

