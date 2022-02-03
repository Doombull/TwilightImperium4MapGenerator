using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal interface ISystem : IComparable<ISystem>
    {
        int Id { get; set; }

        public string GetName();

        public double GetValue();
    }
}
