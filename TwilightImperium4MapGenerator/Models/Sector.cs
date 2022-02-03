using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal class Sector
    {
        public IEnumerable<ISystem> systems { get; set; }
        public double Value { get; set; }

        public void PopulateSector(IEnumerable<ISystem> planetarySystems, IEnumerable<ISystem> spacingSystems)
        {

        }
    }
}
