using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csgolegends_logica_gameplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProPlayerStats statsFallen = new ProPlayerStats(378, 311, 18);
            ProPlayerStats statsFer = new ProPlayerStats(387, 350, 18);
            ProPlayerStats statsBoltz = new ProPlayerStats(329, 342, 18);
            ProPlayerStats statsChelo = new ProPlayerStats(400, 364, 18);
            ProPlayerStats statsVini = new ProPlayerStats(333, 349, 18);

            ProPlayerStats statsYuurih = new ProPlayerStats(134, 114, 8);
            ProPlayerStats statsKscerato = new ProPlayerStats(125, 110, 8);
            ProPlayerStats statsDrop = new ProPlayerStats(117, 126, 8);
            ProPlayerStats statsSaffee = new ProPlayerStats(160, 116, 8);
            ProPlayerStats statsArt = new ProPlayerStats(139, 125, 8);

            ProPlayer fallen = new ProPlayer("FalleN", statsFallen);
            ProPlayer fer = new ProPlayer("fer", statsFer);
            ProPlayer boltz = new ProPlayer("boltz", statsBoltz);
            ProPlayer chelo = new ProPlayer("chelo", statsChelo);
            ProPlayer vini = new ProPlayer("VINI", statsVini);

            ProPlayer yuurih = new ProPlayer("yuurih", statsYuurih);
            ProPlayer kscerato = new ProPlayer("KSCERATO", statsKscerato);
            ProPlayer drop = new ProPlayer("drop", statsDrop);
            ProPlayer saffee = new ProPlayer("saffee", statsSaffee);
            ProPlayer art = new ProPlayer("arT", statsArt);

            List<ProPlayer> proPlayerList1 = new List<ProPlayer>()
            {
                fallen, fer, boltz, chelo,vini
            };


            List<ProPlayer> proPlayerList2 = new List<ProPlayer>()
            {
                yuurih, kscerato, drop, saffee, art
            };

            Team team1 = new Team();
            Team team2 = new Team();

            team1.Name = "Imperial";
            team2.Name = "Furia";

            team1.Country= "Brasil";
            team2.Country = "Brasil";

            team1.ProPlayerList = proPlayerList1;
            team2.ProPlayerList = proPlayerList2;

            Round round = new Round(team1, team2);
            BestOf30 fullGame = new BestOf30(round);

            Console.WriteLine(fullGame);

            Console.ReadKey();

        }
    }
}
