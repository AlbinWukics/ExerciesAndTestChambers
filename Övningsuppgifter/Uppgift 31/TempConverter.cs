namespace Uppgift_31;

public class TempConverter
{
    public void ConvertFromCelsius(float celsius, out float fahrenheit, out float kelvin)
    {
        fahrenheit = (celsius * 9 / 5) + 32f;
        kelvin = celsius + 273.15f;
    }
}