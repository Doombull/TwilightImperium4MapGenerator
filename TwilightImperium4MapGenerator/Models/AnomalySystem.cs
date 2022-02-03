using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal class AnomalySystem : ISystem
    {
        public int Id {get; set;}

        public string Name {get; set;}

        public AnomalySystem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int CompareTo(ISystem? other)
        {
            if (other == null)
                return 1;

            return this.GetValue().CompareTo(other.GetValue());
        }

        public string GetName()
        {
            return Name;
        }

        public double GetValue()
        {
            return 0;
        }
    }
}
