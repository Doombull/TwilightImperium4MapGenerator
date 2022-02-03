using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal class Planet
    {
		public string Name { get; set; }

		public int Resource { get; set; }

		public int Influence { get; set; }

		public TechBonus TechBonus { get; set; }

		public bool IsLegendary { get; set; }

		public double MiscValue { get; set; }

		public Planet(string name, int resource, int influence, TechBonus techBonus = TechBonus.None, bool isLegendary = false, double miscValue = 0)
		{
			Name = name;
			Resource = resource;
			Influence = influence;
			TechBonus = techBonus;
			IsLegendary = isLegendary;
			MiscValue = miscValue;
		}
	}
}
