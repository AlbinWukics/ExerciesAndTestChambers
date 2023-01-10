//Skriv metod: void ConvertDegrees(float Celsius, out float Fahrenheit, out float Kelvin)
//Metoden ska ta antal grader i Celsius in, och man ska få ut motsvarigheten i Fahrenheit och Kelvin i out-parametrarna.
//Ta input från användaren i Celsius, använd metoden och skriv ut resultat.

using Uppgift_31;

var tempConverter = new TempConverter();

var input = float.Parse(Console.ReadLine());
tempConverter.ConvertFromCelsius(input,out var fahrenheit, out var kelvin);

Console.Clear();
Console.WriteLine($"{input} degrees Celsius equals:\n" +
                  $"- {fahrenheit} degrees Fahrenheit\n" +
                  $"- {kelvin} kelvins");
