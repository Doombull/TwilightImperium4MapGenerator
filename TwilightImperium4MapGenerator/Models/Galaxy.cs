using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilightImperium4MapGenerator.Models
{
    internal class Galaxy
    {
        public string? Link { get; set; }
        public List<Sector> Sectors { get; set; }   

        public Galaxy()
        {
            Sectors = new List<Sector>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Link);
            sb.AppendLine();

            for (int i = 0; i < Sectors.Count; i++)
            {
                sb.AppendLine(String.Format("*** Player {0} - {1}", (i + 1), Sectors[i].GetValue()));

                foreach (var system in Sectors[i].Systems)
                {
                    sb.AppendLine(String.Format("{0} - {1}", system.GetName(), system.GetValue()));
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
