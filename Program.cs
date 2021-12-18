using System;
// using MyUtilities; // using namespace, not the class
using static MyUtilities.WeatherUtilities; // another way to do this with C# 6

namespace MyFirstProgram
{
    class HelloWorld
    {
        static float FahreinheitToCelsius(float temperatureFahreinheit)
        {
            var temperatureCelsius = (temperatureFahreinheit - 32) / 1.8f;
            return temperatureCelsius;
        }
        static void Main(string[] args)
        {
            string[] things = { "apple", "banana", "carrot" };
            float comfort = ComfortIndex(50, 50); // don't need WeatherUtilities then
            Console.WriteLine(comfort);
            Console.WriteLine(things[0]);
            float temp = FahreinheitToCelsius(60);
            Console.WriteLine(temp);
        }
    }
}
