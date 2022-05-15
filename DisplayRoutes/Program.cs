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

            Console.WriteLine("Where are you?");
            string origin = Console.ReadLine();

            Console.WriteLine("Where do you want to go?");
            string destination = Console.ReadLine();

            BusRoute[] originRoutes = new BusRoute[5];
            repository.FindBusesTo(origin, ref originRoutes);
            BusRoute[] destinationRoutes = new BusRoute[5];
            repository.FindBusesTo(destination, ref destinationRoutes);

            HashSet<BusRoute> routes = new HashSet<BusRoute>(originRoutes);
            routes.IntersectWith(destinationRoutes);

            BusRoute[] findings = repository.FindBusesBetween(origin, destination);

            foreach (BusRoute route in routes)
            {
                Console.WriteLine(route);
            }

            // BusRoute[] foundRoutes = new BusRoute[5];
            // repository.FindBusesTo(location, ref foundRoutes);

            // if (foundRoutes.Length > 0)
            // {
            //     foreach (BusRoute route in foundRoutes)
            //     {
            //         Console.WriteLine($"You can use route {route}");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine($"No routes go to {location}");
            // }
        }
    }
}
