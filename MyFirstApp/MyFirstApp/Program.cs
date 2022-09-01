// SPARA UPPGIFT 6


while (true)
{
    int sum, numberOfInputs, medelvärde;

    Console.WriteLine("Mata in tal");
    if (int.TryParse(Console.ReadLine(), out var inputNr))
    {
        sum = sum + inputNr;
        numberOfInputs++;
        Console.WriteLine($"Summan av dina tal är {sum}.");
        Console.WriteLine(numberOfInputs);
    }
    else
    {
        medelvärde = sum / numberOfInputs;
        Console.WriteLine($"Medelvärdet på dina inmatade tal är: {medelvärde}.");
        Console.ReadKey(true);
        break;
    }
}
