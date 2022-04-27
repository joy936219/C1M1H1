using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class TurnsOfRound
    {
        private int _turn;
        private InGamePlayer _player;
        private Card _card;
        public TurnsOfRound(int turn, InGamePlayer player, Card card)
        {
            _turn = turn;
            _player = player;
            _card = card;
        }
        public int turn { get => _turn; set => _turn = value; }
        public Card card { get => _card; set => _card = value; }
        public InGamePlayer inGamePlayer { get => _player; set => _player = value; }
    }
}
