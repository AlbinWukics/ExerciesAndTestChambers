//Skriv en klass som representerar en bil.
//Varje bil ska kunna ha en färg som representeras av en enum (det ska finna minst 5 olika färger på bilar), samt en längd.
//När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
//Instansiera 1000 bilar och spara i en array.
//Skriv sedan ut den sammanlagda längden av alla gröna bilar.



var length = 0;
for (int i = 0; i < 1000; i++)
{
    var car = new Car();

    if (car.Color == Colors.green)
    {
        length += car.CarLength;
        Console.WriteLine($"Total length of all green cars: {length}m.\n");
    }

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