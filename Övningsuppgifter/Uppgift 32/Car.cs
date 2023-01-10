//Lägg till en statisk metod på klassen i uppgift 29.
//Metoden ska ta en bil som inparameter och returnera en array med 10 bilar i samma färg, men med olika längd.



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

    public Car(Colors carColor)
    {
        var random = new Random();
        CarLength = random.Next(3, 6);
        Color = carColor;
    }

    public static Car[] TenCars(Car car)
    {
        var cars = new Car[10];
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = new Car(car.Color);
        }
        return cars;
    }

    public override string ToString()
    {
        return $"A {Color} car that is {CarLength}m long.";
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