using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal class ResourceWeightedValuator : IValuator
    {
        public double GetValue(IEnumerable<Planet> planets)
        {
            double value = 0;

            foreach (var planet in planets)
            {
                //Get value of resources and influence
                double resources = planet.Resource;
                double influence = planet.Influence * 2.0 / 3.0;

                if (resources > influence) influence /= 2; else resources /= 2;

                value += resources + influence;

                //Get value of tech bonuses
                if (planet.TechBonus != TechBonus.None)
                {
                    switch (planet.Resource) {
                        case >= 3:
                            value += 1.0 / 3.0;
                            break;
                        case 2:
                            value += 2.0 / 3.0;
                            break;
                        case <= 1:
                            value += 1;
                            break;
                    }
                }

                //Get value of legendary planets
                if (planet.IsLegendary)
                    value += 0.5;

                value += planet.MiscValue;
            }

            return value;
        }
    }
}
