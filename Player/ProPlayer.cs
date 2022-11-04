
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgolegends_logica_gameplay
{
    public class ProPlayer
    {
        public ProPlayer(string name, ProPlayerStats stats)
        {
            Name = name;
            Stats = stats;
            isDead = false;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ProPlayerStats Stats { get; set; }
        public bool isDead { get; set; }
    }
}
