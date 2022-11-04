using csgolegends_logica_gameplay.GamePlay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgolegends_logica_gameplay
{
    public class RoundStats
    {
        public int Id { get; set; }
  
        public TeamsStats TeamStats  { get; set; }
        public GameStats GameStats  { get; set; }
    }   
}
