using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal class EmptySystem : ISystem
    {
        public int Id { get; set; }

        public EmptySystem(int id)
        {
            Id = id;
        }

        public int CompareTo(ISystem? other)
        {
            if (other == null)
                return 1;

            return this.GetValue().CompareTo(other.GetValue());
        }

        public string GetName()
        {
            return "Empty";
        }

        public double GetValue()
        {
            return 0;
        }
    }
}

