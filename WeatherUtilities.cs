using System;

namespace MyUtilities
{
    public class WeatherUtilities // class needs to be public
    {
        static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            var temperatureCelsius = temperatureFahrenheit - 32 / 1.8f;
            return temperatureCelsius;
        }

        static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            var temperatureFahrenheit = temperatureCelsius * 1.8f + 32;
            return temperatureFahrenheit;
        }

        // method needs to be public and static
        public static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            var comfortIndex = (temperatureFahrenheit + humidityPercent) / 4;
            return comfortIndex; // lower the index, the more comfortable
        }

        static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine("Comfort Index for " + location + ": " + ComfortIndex(temperatureFahrenheit, humidity));
        }
    }
}
