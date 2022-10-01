//Skriv en klass som representerar en bil.
//Varje bil ska kunna ha en färg som representeras av en enum (det ska finna minst 5 olika färger på bilar), samt en längd.
//När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
//Instansiera 1000 bilar och spara i en array.
//Skriv sedan ut den sammanlagda längden av alla gröna bilar.

public enum Colors
{
    blue,
    green,
    red,
    yellow,
    orange
}

public class Car
{

    private Colors _color;

    public Colors Color
    {
        get { return _color; }
        set { _color = value; }
    }


    private int _carLength;

    public int CarLength
    {
        get { return _carLength; }
        set { _carLength = value; }
    }

    public Car()
    {
        var random = new Random();
        var colorNum = random.Next(0, 5);
        CarLength = random.Next(3,6);
        Color = (Colors)colorNum;
        Console.WriteLine($"A {Color} car that is {CarLength}m long.");
        
    }
}































//namespace Uppgift_29;

//public enum Colors
//{
//    Blue,
//    Green,
//    Red,
//    Yellow,
//    Pink
//}

//public class Car
//{
//    private Colors _color;

//    public Colors Color
//    {
//        get { return _color; }
//        set { _color = value; }
//    }

//    private int _length;

//    public int Length
//    {
//        get { return _length; }
//        set { _length = value; }
//    }

//    public Car()
//    {
//        var rand = new Random();
//        var colorNum = rand.Next(0, 5);
//        Color = (Colors)colorNum;           //(Colors) som denna datatypen.

//        Length = rand.Next(3,6);
//    }
//}