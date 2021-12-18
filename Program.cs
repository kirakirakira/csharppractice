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
            string[] things = { "apple", "banana", "carrot" };
            float comfort = WeatherUtilities.ComfortIndex(50, 50); // don't need WeatherUtilities then
            WeatherUtilities.Report("Bologna", 23, 65);
            Console.WriteLine(comfort);
            // Console.WriteLine(things[0]);
            float temp = WeatherUtilities.FahrenheitToCelsius(60);
            Console.WriteLine(temp);
        }
    }
}
