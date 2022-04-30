using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class AI_Player : Player
    {
        static Random  rnd = new Random();
        /// <summary>
        /// 隨機選擇電腦玩家手上的牌
        /// </summary>
        /// <param name="cards"></param>
        /// <returns>隨機抽到的牌</returns>
        public override Card CardSelect(List<Card> cards)
        {
            var index = rnd.Next(0, cards.Count());
            return cards[index];
        }
        /// <summary>
        /// 隨機選擇電腦玩家是否要使用交換手牌特權
        /// </summary>
        /// <returns>是/否</returns>
        public override bool UseExchangeHand()
        {
            var select = rnd.Next(0, 2);
            return (select == 1);
        }
        /// <summary>
        /// 隨機選擇電腦玩家是與哪一位玩家交換手牌
        /// </summary>
        /// <param name="inGamePlayers"></param>
        /// <returns>隨機選到的玩家</returns>
        public override InGamePlayer ExchageHandsSelect(List<InGamePlayer> inGamePlayers)
        {
            var index = rnd.Next(0, inGamePlayers.Count());
            return inGamePlayers[index];
        }
    }
}
