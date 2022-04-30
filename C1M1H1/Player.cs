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
        /// 給指令介面的文字 : 是否要使用交換手牌特權
        /// </summary>
        /// <returns></returns>
        protected string UseExchangeHandText()
        {
            var command = $"{_name} : 是否要使用交換手牌特權? 1.是\t2.否";
            return command;
        }
        /// <summary>
        /// 給指令介面的文字 : 請選擇你要交換手牌的玩家
        /// </summary>
        /// <param name="inGamePlayers">除了自己，遊戲中的玩家</param>
        /// <returns></returns>
        protected string ExchangeHandSelectText(List<InGamePlayer> inGamePlayers)
        {
            var players_name = inGamePlayers.Select((p,index) => $"{index+1}. {p.player.name}");
            var command = $"{_name} : 請選擇你要交換手牌的玩家\r\n" + String.Join("\t", players_name);
            return command;
        }
        /// <summary>
        /// 給指令介面的文字 : 請選擇你要出的牌
        /// </summary>
        /// <param name="cards">玩家手上的牌</param>
        /// <returns></returns>
        protected string CardSelectCommandText(List<Card> cards)
        {
            var _cards = cards.Select((s, index) => new { index = index, cmd = $"{index + 1}", name = Enum.GetName(typeof(Suit), s.Suit) + "-" + Enum.GetName(typeof(Rank), s.Rank).Replace("_", "") });
            var command = $"{_name} : 請選擇你要出的牌\r\n" + string.Join("\t", _cards.Select(n => $"{n.cmd}. {n.name}"));
            return command;
        }
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
