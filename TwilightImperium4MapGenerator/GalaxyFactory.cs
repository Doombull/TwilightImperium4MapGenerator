using Newtonsoft.Json;
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
        public static Galaxy? Get8PlayerGalaxy(List<PlanetarySystem> planetarySystems, List<ISystem> spacingSystems)
        {
            //Pull out the 8 high value planets
            var highValueSystems = new List<ISystem>();
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

            highValueSystems.Shuffle();

            //Add 3 planetary systems to each sector, making sure they have at least 6 resources each
            var sectors = new List<Sector>(8);
            for (int i = 0; i < 8; i++)
            {
                sectors.Add(new Sector());
                sectors[i].Systems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());
            }

            for (int i = 7; i >= 0; i--)
            {
                sectors[i].Systems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());

                sectors[i].Systems.Add(planetarySystems[1]);
                planetarySystems.RemoveAt(1);
            }

            if (sectors.OrderBy(s => s.GetResources()).First().GetResources() < 6)
                return null;

            //Randomise each sectors starting position
            sectors.Shuffle();
            var galaxy = new Galaxy();
            galaxy.Sectors = sectors;

            var serialized = JsonConvert.SerializeObject(sectors);
            galaxy.Sectors = JsonConvert.DeserializeObject<List<Sector>>(serialized);

            //Add in the spacing systems
            for (int i = 0; i < 8; i++)
            {
                sectors[i].Systems.Add(spacingSystems[0]);
                spacingSystems.RemoveAt(0);

                if (i != 0 && i != 4)
                {
                    sectors[i].Systems.Add(spacingSystems[0]);
                    spacingSystems.RemoveAt(0);
                }

                sectors[i].Systems.Shuffle();
            }

            //Generate the url link for the galaxy
            var sb = new StringBuilder(300);

            var centerSystems = new List<ISystem>(8);
            centerSystems.AddRange(planetarySystems);
            centerSystems.AddRange(spacingSystems);
            centerSystems.Shuffle();

            sb.Append("/?settings=T80004047FFF&tiles=18");
            for (var i = 0; i < 6; i++)
                sb.Append(GetNextSystemId(centerSystems));

            //2nd Ring
            sb.Append(GetNextSystemId(sectors[0].Systems));
            sb.Append(GetNextSystemId(sectors[1].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[2].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[3].Systems));
            sb.Append(GetNextSystemId(sectors[4].Systems));
            sb.Append(GetNextSystemId(sectors[5].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[6].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[7].Systems));

            //3rd Ring
            sb.Append(GetNextSystemId(sectors[0].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[1].Systems));
            sb.Append(GetNextSystemId(sectors[1].Systems));
            sb.Append(GetNextSystemId(sectors[2].Systems));
            sb.Append(GetNextSystemId(sectors[2].Systems));
            sb.Append(GetNextSystemId(sectors[3].Systems));
            sb.Append(GetNextSystemId(sectors[3].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[4].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[5].Systems));
            sb.Append(GetNextSystemId(sectors[5].Systems));
            sb.Append(GetNextSystemId(sectors[6].Systems));
            sb.Append(GetNextSystemId(sectors[6].Systems));
            sb.Append(GetNextSystemId(sectors[7].Systems));
            sb.Append(GetNextSystemId(sectors[7].Systems));
            sb.Append(GetNextSystemId(highValueSystems));

            //4th Ring
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[0].Systems));
            sb.Append(GetNextSystemId(sectors[1].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[1].Systems));
            sb.Append(GetNextSystemId(sectors[2].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[2].Systems));
            sb.Append(GetNextSystemId(sectors[3].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[3].Systems));
            sb.Append(GetNextSystemId(sectors[4].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[4].Systems));
            sb.Append(GetNextSystemId(sectors[5].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[5].Systems));
            sb.Append(GetNextSystemId(sectors[6].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[6].Systems));
            sb.Append(GetNextSystemId(sectors[7].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[7].Systems));
            sb.Append(GetNextSystemId(sectors[0].Systems));

            galaxy.Link = sb.ToString();
            return galaxy;
        }
        public static string? Get6PlayerGalaxy(List<PlanetarySystem> planetarySystems, List<ISystem> spacingSystems)
        {
            //Pull out the 8 high value planets
            var highValueSystems = new List<ISystem>();
            foreach (var system in planetarySystems)
            {
                if (system.Planets.SingleOrDefault(p => p.IsLegendary) != null)
                    highValueSystems.Add(system);
            }

            planetarySystems.RemoveAll(ps => highValueSystems.Any(hs => hs.Id == ps.Id));

            for (int i = highValueSystems.Count; i < 6; i++)
            {
                highValueSystems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());
            }

            highValueSystems.Shuffle();

            //Add the 2 planetary systems sectors
            var sectors = new List<Sector>(6);
            for (int i = 0; i < 3; i++)
            {
                sectors.Add(new Sector());
                sectors[i].Systems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());
            }

            for (int i = 2; i >= 0; i--)
            {
                sectors[i].Systems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());
            }

            //Add the 3 planetary systems sectors
            for (int i = 3; i < 6; i++)
            {
                sectors.Add(new Sector());
                sectors[i].Systems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());

                sectors[i].Systems.Add(planetarySystems[0]);
                planetarySystems.RemoveAt(0);
            }

            for (int i = 5; i >= 3; i--)
            {
                sectors[i].Systems.Add(planetarySystems.Last());
                planetarySystems.Remove(planetarySystems.Last());
            }

            //Make sure they have at least 6 resources each
            if (sectors.OrderBy(s => s.GetResources()).First().GetResources() < 5)
                return null;

            //Add in the spacing systems
            for (int i = 0; i < 6; i++)
            {
                sectors[i].Systems.Add(spacingSystems[0]);
                spacingSystems.RemoveAt(0);

                if (i < 3)
                {
                    sectors[i].Systems.Add(spacingSystems[0]);
                    spacingSystems.RemoveAt(0);
                }

                sectors[i].Systems.Shuffle();
            }

            //Randomise each sectors starting position
            sectors.Shuffle();

            //Generate the url link for the galaxy
            var sb = new StringBuilder(300);

            var centerSystems = new List<ISystem>(8);
            centerSystems.AddRange(planetarySystems);
            centerSystems.AddRange(spacingSystems);
            centerSystems.Shuffle();

            sb.Append("/?settings=T60003706FFF&tiles=18");

            //1st Ring
            sb.Append(GetNextSystemId(sectors[0].Systems));
            sb.Append(GetNextSystemId(sectors[1].Systems));
            sb.Append(GetNextSystemId(sectors[2].Systems));
            sb.Append(GetNextSystemId(sectors[3].Systems));
            sb.Append(GetNextSystemId(sectors[4].Systems));
            sb.Append(GetNextSystemId(sectors[5].Systems));

            //2nd Ring
            sb.Append(GetNextSystemId(sectors[0].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[1].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[2].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[3].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[4].Systems));
            sb.Append(GetNextSystemId(highValueSystems));
            sb.Append(GetNextSystemId(sectors[5].Systems));
            sb.Append(GetNextSystemId(highValueSystems));

            //3rd Ring
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[0].Systems));
            sb.Append(GetNextSystemId(sectors[1].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[1].Systems));
            sb.Append(GetNextSystemId(sectors[2].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[2].Systems));
            sb.Append(GetNextSystemId(sectors[3].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[3].Systems));
            sb.Append(GetNextSystemId(sectors[4].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[4].Systems));
            sb.Append(GetNextSystemId(sectors[5].Systems));
            sb.Append(",0");
            sb.Append(GetNextSystemId(sectors[5].Systems));
            sb.Append(GetNextSystemId(sectors[0].Systems));

            return sb.ToString();
        }

        internal static string GetNextSystemId(List<ISystem> system)
        {
            var id = system[0].Id;
            system.RemoveAt(0);

            return ',' + id.ToString();
        }
    }
}
