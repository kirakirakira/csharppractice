using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.ArraysCollections.Demos
{
    public class BusRouteRepository
    {
        private readonly BusRoute[] _allRoutes;
        public void FindBusesTo(string location, ref BusRoute[] foundRoutes)
        {
            try
            {
                BusRoute[] returnedRoutes = Array.FindAll(_allRoutes,
                    route => route.Serves(location));

                foundRoutes = returnedRoutes;
            }
            catch (NullReferenceException e)
            {
                Console.Write("Exception thrown: ");

                Console.Write("{0}", e.GetType(), e.Message);
            }
        }

        public BusRoute[] FindBusesBetween(string origin, string destination)
        {
            return Array.FindAll(_allRoutes,
                route => route.Serves(origin) && route.Serves(destination));
        }

        public F()
        {
            _allRoutes = new BusRoute[] {
                new BusRoute(40, new string[] { "Morecambe", "Preston" }),
                new BusRoute(42, new string[] { "Lancaster", "Blackpool" }),
                new BusRoute(100, new string[] { "Kira", "Bob" }),
                new BusRoute(120, new string[] { "Bob", "Kira" })
            };
        }
    }
}
