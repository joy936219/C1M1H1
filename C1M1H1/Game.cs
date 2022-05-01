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
        private List<RoundsOfGame> _gameRounds;
        private int _maxGameRounds = 13;
        private int _maxPlayers = 4;
       
        public Game(Deck deck,List<InGamePlayer> inGamePlayers, List<RoundsOfGame> gameRounds)
        {
            _deck = deck;
            _inGamePlayers = inGamePlayers;
            _gameRounds = gameRounds;
        }
        public Deck deck { get => _deck; set => _deck = value; }
        public List<InGamePlayer> inGamePlayers { get => _inGamePlayers; set => _inGamePlayers = value; }
        /// <summary>
        /// 加入玩家
        /// </summary>
        /// <param name="player">玩家</param>
        /// <returns>加入遊戲的玩家</returns>
        /// <exception cref="Exception">超過支援的玩家人數</exception>
        public InGamePlayer JoinPlayer(Player player)
        {
            int player_amount = _inGamePlayers.Count();
            if(player_amount == _maxPlayers)
            {
                throw new Exception(message : $"此遊戲只支援{_maxPlayers}個玩家");
            }
            int sort = player_amount + 1;
            InGamePlayer inGamePlayer = new InGamePlayer(player, this, new List<Card>(), sort);
            _inGamePlayers.Add(inGamePlayer);
            Console.Write($"玩家 : {player.name} 加入遊戲 \r\n");
            return inGamePlayer;
        }
        /// <summary>
        /// 遊戲開始
        /// </summary>
        public void Start()
        {
            Console.WriteLine("開始進行遊戲 \r\n");
            _deck.Shuffle();
            DarwCard();
            StartRound();
        }
        /// <summary>
        /// 遊戲結束,顯示勝者
        /// </summary>
        public void Over()
        {
            var top = _inGamePlayers.OrderByDescending(p => p.point).FirstOrDefault();
            Console.WriteLine($"遊戲結束 勝者 : {top.player.name}  分數 : {top.point}\r\n");
        }
        /// <summary>
        /// 玩家依序抽牌
        /// </summary>
        public void DarwCard()
        {
            Console.WriteLine("開始進行抽牌 \r\n");
            for (int round = 1;round <= _maxGameRounds; round++)
            {
                foreach (var player in _inGamePlayers)
                {
                    var card = player.DrawCard();
                    player.AddHandCard(card);
                }
            }
        }
        /// <summary>
        /// 開始每回合
        /// </summary>
        public void StartRound()
        {
            Console.WriteLine("回合開始 \r\n");
            for(int round = 1; round <= _maxGameRounds; round++)
            {
                Console.WriteLine($"第{round}回合開始 \r\n");
                RoundsOfGame gameRounds = new RoundsOfGame(_inGamePlayers, new List<TurnsOfRound>(),  round);
                _gameRounds.Add(gameRounds);
                gameRounds.UseExchangeHand();
                gameRounds.ShowPlayersCard();
                gameRounds.DisplayPlayersCard();
                var winner = gameRounds.ComparePlayersCard();
                winner.GainPoint();
                Console.WriteLine($"第{round}回合 , {winner.player.name} 得1分, 總計 {winner.point}分 \r\n");
                gameRounds.ShowPlayerUseExchangeHandRemainingRound();
            }
        }
    }
}
