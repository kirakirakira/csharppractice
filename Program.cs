using System;
// using MyUtilities; // using namespace, not the class
// using static MyUtilities.WeatherUtilities; // another way to do this with C# 6
using MyUtilities;

namespace MyFirstProgram
{
    class HelloWorld
    {
        static float FahrenheitToCelsius(float temperatureFahreinheit)
        {
            var temperatureCelsius = (temperatureFahreinheit - 32) / 1.8f;
            Console.WriteLine("in my first program");
            return temperatureCelsius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Where should we go in May?");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("Bologna", 23, 65);
        }
    }
}
