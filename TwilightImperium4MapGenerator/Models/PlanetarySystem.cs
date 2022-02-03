using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal class PlanetarySystem : ISystem
    {
        protected double? value;

        public int Id { get; set; }

        public IEnumerable<Planet> Planets { get; set; }

        public IValuator valuator { get; set; }

        public PlanetarySystem()
        {
            Planets = new List<Planet> ();
            valuator = new ResourceWeightedValuator();
        }

        public PlanetarySystem(int id, IEnumerable<Planet> planets) : this()
        {
            Id = id;
            Planets = planets;
        }

        public string GetName()
        {
            return String.Join(", ", Planets.Select(p => p.Name));
        }

        public double GetValue()
        {
            if (value is null)
            {
                value = valuator.GetValue(Planets);
                value += Random.Next() / 100;
            }

            return value.Value;
        }
        public int CompareTo(ISystem? other)
        {
            if (other == null)
                return 1;

            return this.GetValue().CompareTo(other.GetValue());
        }

    }
}
