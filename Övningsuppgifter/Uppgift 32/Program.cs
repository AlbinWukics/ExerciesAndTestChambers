//Lägg till en statisk metod på klassen i uppgift 29.
//Metoden ska ta en bil som inparameter och returnera en array med 10 bilar i samma färg, men med olika längd.


//var length = 0;
//for (int i = 0; i < 1000; i++)
//{
    var car = new Car(Colors.green);

//    if (car.Color == Colors.green)
//    {
//        length += car.CarLength;
//        Console.WriteLine($"Total length of all green cars: {length}m.\n");
//    }

//}
 
var tenCars = Car.TenCars(car);

    foreach (var tenCar in tenCars)
    {
        Console.WriteLine(tenCar);
    }































//using Uppgift_29;

//var car = new Car();

//Console.WriteLine($"Car color is {car.Color} and car length is {car.Length}.");





//var cars = new Car[1000];

//for (int i = 0; i < cars.Length; i++)
//{
//    cars[i] = new Car();
//}

//var sumLength = 0;

//foreach (var car in cars)
//{
//    if (car.Color == Colors.Green)
//    {
//        sumLength += car.Length;
//    }
//}