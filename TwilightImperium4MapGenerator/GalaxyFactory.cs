using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwilightImperium4MapGenerator.Models;

namespace TwilightImperium4MapGenerator
{
    internal static class GalaxyFactory
    {
        public static IEnumerable<Sector> Get8PlayerGalaxy(List<PlanetarySystem> planetarySystems, List<ISystem> spacingSystems)
        {
            //Pull out the 8 high value planets
            var highValueSystems = new List<PlanetarySystem>();
            foreach (var system in planetarySystems)
            {
                if (system.Planets.SingleOrDefault(p => p.IsLegendary) != null)
                    highValueSystems.Add(system);
            }

            planetarySystems.RemoveAll(ps => highValueSystems.Any(hs => hs.Id == ps.Id));

            for (int i = highValueSystems.Count; i < 8 ; i++)
            {
                highValueSystems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());
            }

            //Add 3 planetary systems to each sector
            Sector[] initialSectorAllocation = new Sector[8];
            for (int i = 0; i < 8; i++)
            {
                initialSectorAllocation[i] = new Sector();
                initialSectorAllocation[i].Systems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());
            }

            for (int i = 7;i >= 0;i--)
            {
                initialSectorAllocation[i].Systems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());

                initialSectorAllocation[i].Systems.Add(planetarySystems[1]);
                planetarySystems.RemoveAt(1);
            }

            return initialSectorAllocation;
        }
    }
}
