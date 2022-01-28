using System;
using System.Collections.Generic;
using Pluralsight.ArraysCollections.Demos;

namespace Pluralsight.ArraysCollections.Demos
{
    class Program
    {
        public static void FindBusTo(BusRoute[] routes, string location, ref BusRoute foundRoute)
        {
            try
            {
                BusRoute route = Array.Find(routes,
                    route => route.Origin == location || route.Destination == location);
                Console.WriteLine(route);

                foundRoute = route;
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

            // foreach (BusRoute route in routes)
            //     Console.WriteLine(route);

            BusRoute foundRoute = new BusRoute(5, "Ryan", "Emma");
            FindBusTo(routes, "Kira", ref foundRoute);

            if (foundRoute != null)
                Console.WriteLine(foundRoute);
            else
                Console.WriteLine("No routes");


        }
    }
}
