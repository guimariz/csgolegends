using csgolegends_logica_gameplay.Player;
using System.Collections.Generic;
using System.Linq;

namespace csgolegends_logica_gameplay
{
    public class ProPlayerStats
    {
        public ProPlayerStats(double totalKills, double totalDeaths, int totalMatches)
        {
            TotalKills = totalKills;
            TotalDeaths = totalDeaths;
            KDStats = TotalKills / TotalDeaths;
            TotalMatches = totalMatches;
            //desenvolver a lógica de cada player -> o que ele pode fazer;
        }
        public double KDStats { get; set; }
        public double TotalKills { get; set; }
        public double TotalDeaths { get; set; }
        public int TotalMatches { get; set; }
        public ProPlayerAverage KillDeathAverage { get; set; }
    }
}
