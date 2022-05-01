using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal abstract class Player
    {
        private string _name;
        public string name { get => _name; set => _name = value; }
        public abstract bool UseExchangeHand();
        public abstract InGamePlayer ExchageHandsSelect(List<InGamePlayer> inGamePlayers);
        public abstract Card CardSelect(List<Card> cards);
       
        /// <summary>
        /// 玩家取名字
        /// </summary>
        /// <param name="name">名字</param>
        public void Name_himself(string name)
        {
            _name = name;
        }
    }
}
