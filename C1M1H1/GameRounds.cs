using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class GameRounds
    {
        private InGamePlayer _InGamePlayer;
        private int _round;
        private int _point;
        

        public GameRounds(InGamePlayer inGamePlayer, int round, int point)
        {
            _InGamePlayer = inGamePlayer;
            _round = round;
            _point = point;
        }

        public int round { get => _round; set { _round = value; } } 
        public int point { get => _point; set { _point = value; } } 

        
    }
}
