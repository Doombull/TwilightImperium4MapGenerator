using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal class HomeSystem : ISystem
    {
        public int Id { get; set; }

        public HomeSystem()
        {
            Id = 0;
        }

        public int CompareTo(ISystem? other)
        {
            return 1;
        }

        public string GetName()
        {
            return "Home System";
        }

        public double GetValue()
        {
            return 0;
        }
    }
}
