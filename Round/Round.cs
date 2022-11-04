using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgolegends_logica_gameplay
{
    public class Round
    {
        public Round(Team team1, Team team2)
        {
            this.Id = Id;
            Team1 = team1;
            Team2 = team2;
            RoundMatch(Team1, Team2);
        }

        public string RoundMatch(Team Team1, Team Team2)
        {
            foreach(ProPlayer p in Team1.ProPlayerList)
            {
                
            }
            //while(true)
            //{

                //if (Team1.ProPlayerList.Count() < 1)
                //{
                //    WinningTeam = Team2;
                //    break;
                //}
                //if (Team2.ProPlayerList.Count() < 1)
                //{
                //    WinningTeam = Team1;
                //    break;
                //}

                //ProPlayer player1 = Team1.ProPlayerList[0];
                //ProPlayer player2 = Team2.ProPlayerList[0];

                //int qtdKillsPlayer1 = rnd.Next(0, 5);
                    
                //Console.WriteLine($"Rodada {i} Player 1 {qtdKillsPlayer1}");

                //Team2.ProPlayerList = Team2.ProPlayerList.Skip(qtdKillsPlayer1).ToList();

                //int qtdKillsPlayer2 = rnd.Next(0, 5);

                //Console.WriteLine($"Rodada {i} Player 2 {qtdKillsPlayer2}");
                //Team1.ProPlayerList = Team1.ProPlayerList.Skip(qtdKillsPlayer2).ToList();
            //}

            return null;
        }

        public int Id { get; set; }
        public double Kills { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public string WinningTeam { get; set; }
        public string LoosingTeam { get; set; }

    }
}
