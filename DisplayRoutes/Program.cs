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
                    route => route.Origin == location || route.Destination == location);

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
            BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
            BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

            // BusRoute[] routes =
            // {
            //     route40,
            //     route42,
            //     new BusRoute(100, "University", "Morecambe"),
            //     new BusRoute(555, "Lancaster", "Keswick")
            // };

            // BusRoute firstRoute = routes[0];
            // Console.WriteLine(firstRoute);

            // BusRoute lastRoute = routes[routes.Length - 1];
            // Console.WriteLine(lastRoute);
            BusRoute[] routes = new BusRoute[4];

            routes[0] = route40;
            routes[1] = route42;
            routes[2] = new BusRoute(100, "Kira", "Bob");
            routes[3] = new BusRoute(120, "Bob", "Kira");

            // foreach (BusRoute route in routes)
            //     Console.WriteLine(route);

            BusRoute[] foundRoutes = new BusRoute[4];
            FindBusesTo(routes, "Kira", ref foundRoutes);

            if (foundRoutes != null)
                foreach (BusRoute route in foundRoutes)
                    Console.WriteLine(route);
            else
                Console.WriteLine("No routes");


        }
    }
}
