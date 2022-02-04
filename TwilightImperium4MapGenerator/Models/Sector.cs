using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal class Sector
    {
        public List<ISystem> Systems { get; set; }

        public Sector()
        {
            Systems = new List<ISystem>();
        }

        public double GetValue()
        {
            var value = 0.0;
            foreach (var system in Systems)
                value += system.GetValue();

            return value;
        }

        public int GetResources()
        {
            var resources = 0;
            foreach (var system in Systems)
            {
                if (system is PlanetarySystem)
                    foreach (var planet in ((PlanetarySystem)system).Planets)
                        resources += planet.Resource;
            }

            return resources;
        }
    }
}
