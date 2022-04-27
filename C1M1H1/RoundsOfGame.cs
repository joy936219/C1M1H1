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
        

        public RoundsOfGame(List<InGamePlayer> inGamePlayers, List<TurnsOfRound> turnsOfRounds, int round)
        {
            _InGamePlayers = inGamePlayers;
            _round = round;
            _turnsOfRounds = turnsOfRounds;
        }

        public int round { get => _round; set => _round = value;  } 
        public InGamePlayer winner_player { get => _winner_Player; set => _winner_Player = value;}

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
        public void DisplayPlayersCard()
        {
            foreach(var turn in _turnsOfRounds)
            {
                Console.WriteLine($"{turn.inGamePlayer.player.name} 出了 {Enum.GetName(typeof(Suit), turn.card.Suit) + "-" + Enum.GetName(typeof(Rank), turn.card.Rank).Replace("_", "")} \r\n");
            }
        }

        public InGamePlayer ComparePlayersCard()
        {
           var winner =  _turnsOfRounds.OrderByDescending(c => (int)c.card.Rank).ThenByDescending(c => (int)c.card.Suit).FirstOrDefault();
            _winner_Player = winner.inGamePlayer;
            return _winner_Player;
        }
        
    }
}
