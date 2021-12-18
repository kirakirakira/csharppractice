using System;

namespace MyUtilities
{
    public class WeatherUtilities // class needs to be public
    {
        public static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            Console.WriteLine("inside the weather class");
            return temperatureFahrenheit - 32 / 1.8f;
        }

        static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return temperatureCelsius * 1.8f + 32;
        }

        // method needs to be public and static
        public static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            // lower the index, the more comfortable
            return (temperatureFahrenheit + humidityPercent) / 4;
        }

        public static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine("Comfort Index for " + location + ": " + ComfortIndex(temperatureFahrenheit, humidity));
        }
    }
}
