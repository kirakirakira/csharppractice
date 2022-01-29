using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.ArraysCollections.Demos
{
    public class BusRouteRepository
    {
        public static List<BusRoute> InitializeRoutes()
        {
            return new List<BusRoute>
            {
                new BusRoute(40, new string[] { "Morecambe", "Preston" }),
                new BusRoute(42, new string[] { "Lancaster", "Blackpool" }),
                new BusRoute(100, new string[] { "Kira", "Bob" }),
                new BusRoute(120, new string[] { "Bob", "Kira" }),
                new BusRoute(1_000, new string[] { "Test origin", "Test destination" })
            };
        }
    }
}
