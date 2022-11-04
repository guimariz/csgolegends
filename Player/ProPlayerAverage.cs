using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgolegends_logica_gameplay.Player
{
    public class ProPlayerAverage
    {
        public ProPlayerAverage(double kills, double deaths, int totalMatches)
        {
            KillsAverage = kills / totalMatches;
            DeathsAverage = deaths / totalMatches;
        }

        public int Id { get; set; }
        public double KillsAverage { get; set; }
        public double DeathsAverage { get; set; }
    }
}
