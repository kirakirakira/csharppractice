using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.ArraysCollections.Demos
{
    public class BusRouteRepository
    {
        // public static List<BusRoute> InitializeRoutes()
        // {
        //     return new List<BusRoute>
        //     {
        //         new BusRoute(40, new string[] { "Morecambe", "Preston" }),
        //         new BusRoute(42, new string[] { "Lancaster", "Blackpool" }),
        //         new BusRoute(100, new string[] { "Kira", "Bob" }),
        //         new BusRoute(120, new string[] { "Bob", "Kira" }),
        //         new BusRoute(1_000, new string[] { "Test origin", "Test destination" })
        //     };
        // }

        public static SortedDictionary<int, BusRoute> InitializeRoutes()
        {
            BusRoute route40 = new BusRoute(40, new string[] { "Morecambe", "Preston" });
            BusRoute route42 = new BusRoute(42, new string[] { "Lancaster", "Blackpool" });
            BusRoute route100 = new BusRoute(100, new string[] { "Kira", "Bob" });
            BusRoute route120 = new BusRoute(120, new string[] { "Bob", "Kira" });
            BusRoute route1_000 = new BusRoute(1_000, new string[] { "Test origin", "Test destination" });

            var routes = new SortedDictionary<int, BusRoute>();
            routes.Add(42, route42);
            routes.Add(40, route40);
            routes.Add(1000, route1_000);
            routes.Add(100, route100);
            routes.Add(120, route120);

            return routes;
        }
    }
}
