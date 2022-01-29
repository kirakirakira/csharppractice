using System;
using System.Collections.Generic;
using Pluralsight.ArraysCollections.Demos;

namespace Pluralsight.ArraysCollections.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRouteRepository repository = new BusRouteRepository();

            Console.WriteLine("Where do you want to go?");
            string location = Console.ReadLine();
            BusRoute[] foundRoutes = new BusRoute[5];
            repository.FindBusesTo(location, ref foundRoutes);

            if (foundRoutes.Length > 0)
            {
                foreach (BusRoute route in foundRoutes)
                {
                    Console.WriteLine($"You can use route {route}");
                }
            }
            else
            {
                Console.WriteLine($"No routes go to {location}");
            }
        }
    }
}
