//UPPGIFT 20

//Använd DrawBox-metoden i föregående uppgift för att rita en box.
//Placera sedan ett @ i mitten av boxen.
//Om man använder piltangenterna ska man kunna flytta runt @.
//När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.
//Hint: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
//Spara bredd och höjd på boxen så du vet när den ska stanna.


class Uppgift20
{
    static void Main(string[] args)
    {
        MovingDrawBox(15, 10);
    }

    static void MovingDrawBox(int width, int height)
    {
        int heightPos = height / 2;
        int widthPos = width / 2;

        Console.CursorVisible = false;

        while (true)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        Console.Write("#");
                    }
                    else if (i == heightPos && j == widthPos)
                    {
                        Console.Write("@");
                    }
                    else if (heightPos == 0 || heightPos == height-1 || widthPos == 0 || widthPos == width-1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\n\n\n\n\tYOU DIED");
                        Console.ForegroundColor = ConsoleColor.Black;
                        return;
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }

            char input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case 'w':
                    heightPos--;
                    break;
                case 's':
                    heightPos++;
                    break;
                case 'a':
                    widthPos--;
                    break;
                case 'd':
                    widthPos++;
                    break;
                default:

                    return;
            }
            Console.Clear();
        }
    }
}

//FÖR ATT ANVÄNDA PILTANGENTERNA SE NEDANSTÅENDE

//ConsoleKeyInfo _Key = Console.ReadKey();

//switch (_Key.Key)
//{
//    case ConsoleKey.RightArrow:
//        Console.WriteLine("Right Arrow");
//        break;
//    case ConsoleKey.LeftArrow:
//        Console.WriteLine("Left Arrow");
//        break;
//    default:
//        break;
//}
