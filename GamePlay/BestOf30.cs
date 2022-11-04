using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgolegends_logica_gameplay
{
    public class BestOf30
    {
        
        public BestOf30(Round round)
        {
            ReturnRoundControl = RoundControl(round);
            FullGameRound.Add(ReturnRoundControl);
            Console.WriteLine(ReturnRoundControl);
        }
        public Round RoundControl(Round round)
        {
            //16 rounds -> vencedor
            Console.WriteLine(round.Team2.Country);
            return round;
        }
        public int Id { get; set; }
        public Round Round { get; set; }
        public Round ReturnRoundControl { get; set; }
        public List<Round> FullGameRound { get; set; }
    }
}
