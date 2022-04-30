using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class RoundsOfGame
    {
        private List<InGamePlayer> _InGamePlayers;
        private List<TurnsOfRound> _turnsOfRounds;
        private InGamePlayer _winner_Player;
        private int _round;
        
        /// <summary>
        /// 遊戲的每一回合
        /// </summary>
        /// <param name="inGamePlayers">遊戲中的玩家</param>
        /// <param name="turnsOfRounds">每回合中的輪次</param>
        /// <param name="round">第n回合</param>
        public RoundsOfGame(List<InGamePlayer> inGamePlayers, List<TurnsOfRound> turnsOfRounds, int round)
        {
            _InGamePlayers = inGamePlayers;
            _round = round;
            _turnsOfRounds = turnsOfRounds;
        }

        public int round { get => _round; set => _round = value;  } 
        public InGamePlayer winner_player { get => _winner_Player; set => _winner_Player = value;}
        /// <summary>
        /// 4個玩家依序出牌
        /// </summary>
        public void ShowPlayersCard()
        {
            foreach(var player in _InGamePlayers)
            {
                int turn = player.sort;
                var card = player.Show();
                TurnsOfRound turnsOfRound = new TurnsOfRound(turn, player, card);
                _turnsOfRounds.Add(turnsOfRound);
            }
        }
        /// <summary>
        /// 4個玩家依序顯示出的牌
        /// </summary>
        public void DisplayPlayersCard()
        {
            foreach(var turn in _turnsOfRounds)
            {
                Console.WriteLine($"{turn.inGamePlayer.player.name} 出了 {Enum.GetName(typeof(Suit), turn.card.Suit) + "-" + Enum.GetName(typeof(Rank), turn.card.Rank).Replace("_", "")} \r\n");
            }
        }
        /// <summary>
        /// 比較4個玩家的牌
        /// </summary>
        /// <returns>遊戲中牌最大的玩家</returns>
        public InGamePlayer ComparePlayersCard()
        {
           var winner =  _turnsOfRounds.OrderByDescending(c => (int)c.card.Rank).ThenByDescending(c => (int)c.card.Suit).FirstOrDefault();
            _winner_Player = winner.inGamePlayer;
            return _winner_Player;
        }
        /// <summary>
        /// 依序詢問玩家是否要使用交換手牌特權
        /// </summary>
        public void UseExchangeHand()
        {
            foreach(var player in _InGamePlayers)
            {
                if (!player.isUseExchangeHands)
                {
                    player.UseExchangeHands();
                }
            }
        }
        /// <summary>
        /// 依序顯示已經使用交換手牌特權的玩家剩下多少回合要交換回來
        /// </summary>
        public void ShowPlayerUseExchangeHandRemainingRound()
        {
            foreach(var player in _InGamePlayers)
            {
                if (player.isUseExchangeHands && player.exchange_hands.changeback_round >= 0)
                {
                    Console.WriteLine($"{player.player.name} 交換手牌回合剩餘 : {player.exchange_hands.changeback_round} \r\n");
                    if (player.exchange_hands.changeback_round == 0)
                    {
                        player.exchange_hands.ChangeBackHand();
                    }
                    player.exchange_hands.changeback_round--;
                    
                }        
            }
        }
        
    }
}
