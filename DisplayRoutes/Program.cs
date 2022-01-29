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
            List<BusRoute> routes = BusRouteRepository.InitializeRoutes();
            foreach (BusRoute route in routes)
                Console.WriteLine(route);

            routes.RemoveAll(route => route.Origin.StartsWith("Test "));

            foreach (BusRoute route in routes)
                Console.WriteLine(route);


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
