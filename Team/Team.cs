using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgolegends_logica_gameplay
{
    public class Team
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<ProPlayer> ProPlayerList { get; set; }

    }
}
