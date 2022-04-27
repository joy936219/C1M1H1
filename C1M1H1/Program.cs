using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new Deck(), new List<InGamePlayer>(), new List<RoundsOfGame>());

            Player p1 = new AI_Player();
            Player p2 = new AI_Player();
            Player p3 = new AI_Player();
            Player p4 = new AI_Player();

            p1.Name_himself("玩家1");
            p2.Name_himself("玩家2");
            p3.Name_himself("玩家3");
            p4.Name_himself("玩家4");

            game.JoinPlayer(p1);
            game.JoinPlayer(p2);
            game.JoinPlayer(p3);
            game.JoinPlayer(p4);

            game.Start();

            Console.ReadLine();


        }
    }
}
