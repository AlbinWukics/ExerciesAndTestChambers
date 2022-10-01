//Skapa en en klass som har en property “red” och en property “blue”.
//Båda ska vara en float och kunna ha ett värde mellan 0.0 och 100.0 men
//de ska vara “sammankopplade” på så vis att värdena tillsammans alltid är 100.0 d.v.s
//om man t.ex. sätter “blue” till 8.5 och sedan läser av “red” så ska den returnera 91.5


var color = new Color();

color.Red = 25.5f;

Console.WriteLine($"Blue: {color.Blue}, red: {color.Red}.");






























//using Uppgift_27;

//var color = new Color();

//Console.WriteLine($"Red: {color.Red}, blue: {color.Blue}.");

//color.Red = 20;
//Console.WriteLine($"Red: {color.Red}, blue: {color.Blue}.");

//color.Blue = 10;
//Console.WriteLine($"Red: {color.Red}, blue: {color.Blue}.");

//color.Red = 6.3f;
//Console.WriteLine($"Red: {color.Red}, blue: {color.Blue}.");


//color.Red = -10;
//Console.WriteLine($"Red: {color.Red}, blue: {color.Blue}.");
