using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class Game
    {
        private Deck _deck;
        private List<InGamePlayer> _inGamePlayers;
       
        public Game(Deck deck,List<InGamePlayer> inGamePlayers)
        {
            _deck = deck;
            _inGamePlayers = inGamePlayers;
        }
        public Deck deck { get => _deck; set => _deck = value; }

        public InGamePlayer JoinPlayer(Player player)
        {
            int player_amount = _inGamePlayers.Count();
            if(player_amount == 4)
            {
                throw new Exception(message : "此遊戲只支援4個玩家");
            }
            int sort = player_amount + 1;
            InGamePlayer inGamePlayer = new InGamePlayer(player, this, new List<Card>(), new List<GameRounds>(), sort);
            _inGamePlayers.Add(inGamePlayer);
            Console.Write($"玩家 : {player.name} 加入遊戲 \r\n");
            return inGamePlayer;
        }

        public void Start()
        {
            Console.WriteLine("開始進行遊戲 \r\n");
            _deck.Shuffle();
            DarwCard();
            StartRound();
        }

        public void DarwCard()
        {
            Console.WriteLine("開始進行抽牌 \r\n");
            for (int round = 1;round <= 13; round++)
            {
                //Console.WriteLine($"抽牌第{round}輪 \r\n");
                foreach (var player in _inGamePlayers)
                {
                    var card = player.DrawCard();
                    player.AddHandCard(card);
                }
            }
        }

        public void StartRound()
        {
            Console.WriteLine("回合開始 \r\n");
            for(int round =1; round <= 13; round++)
            {
                var p1 = _inGamePlayers[0].Show();
                var p2 = _inGamePlayers[1].Show();
            }
        }
    }
}
