using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class Exchange_Hands
    {
        private InGamePlayer _exchange_player;
        private InGamePlayer _exchanged_player;
        private int _changeback_round = 3;
        public InGamePlayer change_player { get => _exchange_player; set => _exchange_player = value; }
        public InGamePlayer exchanged_player { get => _exchanged_player; set => _exchanged_player = value;}
        public int changeback_round { get => _changeback_round;set => _changeback_round = value;}

        public Exchange_Hands(InGamePlayer exchange_player, InGamePlayer exchanged_player)
        {
            _exchange_player = exchange_player;
            _exchanged_player = exchanged_player;
        }
        /// <summary>
        /// 交換手牌
        /// </summary>
        public void ExchangeHand()
        {
            var temp = _exchange_player.hand_cards;
            _exchange_player.hand_cards = _exchanged_player.hand_cards;
            _exchanged_player.hand_cards = temp;
            Console.WriteLine($"{_exchange_player.player.name} 使用了交換手牌特權，與 {_exchanged_player.player.name} 交換了手牌 \r\n");
        }
        /// <summary>
        /// 手牌換回來
        /// </summary>
        public void ChangeBackHand()
        {
            var temp = _exchanged_player.hand_cards;
            _exchanged_player.hand_cards = _exchange_player.hand_cards;
            _exchange_player.hand_cards = temp;
            Console.WriteLine($"{_exchange_player.player.name} 與 {_exchanged_player.player.name} 手牌換回來 \r\n");
        }
    }
}
