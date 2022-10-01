//UPPGIFT 21

//1: Skriv om DrawBox så den istället returnerar en 2D-array av char med tecknen som den tidigare skrev ut på displayen.

//2: Man ska också kunna mata in en tredje parameter för antal slumpade ‘#’.
//Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på random ställen inne i boxen.

//Row lodrätt. Column vågrätt

class Uppgift21
{
    static void Main(string[] args)
    {
        DrawBox();
    }
    static void DrawBox()
    {
        int[,] array = new int [2,3] { {1,2,3 }, {3,4,5 } };
        Console.WriteLine(array[0,1]);

    }
}