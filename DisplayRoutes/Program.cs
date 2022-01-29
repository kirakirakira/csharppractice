using System;
using System.Collections.Generic;
using Pluralsight.ArraysCollections.Demos;

namespace Pluralsight.ArraysCollections.Demos
{
    class Program
    {
        public static void FindBusesTo(BusRoute[] routes, string location, ref BusRoute[] foundRoutes)
        {
            try
            {
                BusRoute[] returnedRoutes = Array.FindAll(routes,
                    route => route.Serves(location));

                foundRoutes = returnedRoutes;
            }
            catch (NullReferenceException e)
            {
                Console.Write("Exception thrown: ");

                Console.Write("{0}", e.GetType(), e.Message);
            }
        }
        static void Main(string[] args)
        {
            var routes = BusRouteRepository.InitializeRoutes();

            foreach (BusRoute route in routes.Values)
            {
                Console.WriteLine(route);
            }
            // BusRoute foundRoute = routes[40];
            // Console.WriteLine(foundRoute);

            // int number = 25;

            // // bool success = routes.TryGetValue(number, out BusRoute? answer);
            // bool success = routes.ContainsKey(number);

            // if (success)
            // {
            //     Console.WriteLine($"The route you asked for is {routes[number]}");
            // }
            // else
            // {
            //     Console.WriteLine($"There is no route with number {number}");
            // }
            // foreach (BusRoute route in routes)
            //     Console.WriteLine(route);

            // routes.RemoveAll(route => route.Origin.StartsWith("Test "));

            // foreach (BusRoute route in routes)
            //     Console.WriteLine(route);


            // BusRoute[] foundRoutes = new BusRoute[5];
            // FindBusesTo(routes, "Kira", ref foundRoutes);

            // if (foundRoutes != null)
            //     foreach (BusRoute route in foundRoutes)
            //         Console.WriteLine(route);
            // else
            //     Console.WriteLine("No routes");


        }
    }
}
