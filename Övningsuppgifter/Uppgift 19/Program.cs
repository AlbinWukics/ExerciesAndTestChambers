//UPPGIFT 19

//Skriv en metod DrawBox(int width, int height)
//När man anropar metoden ska den tömma konsolen
//och skriva ut en rektangel där de yttre tecknen består av ‘#’ och de inre av ‘-’ Exempel:
//DrawBox(7, 4);
//#######
//#-----#
//#-----#
//#######

class uppgift19
{
    static void Main(string[] args)
    {
        DrawBox(26, 14);
    }

    static void DrawBox(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                {
                    Console.Write("#");
                }
                else if (i == height / 2 && j == width / 2)
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
    }
}