using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class Human_Player : Player
    {
        public static CommandLineInterface commandLineInterface = new CommandLineInterface();
        /// <summary>
        /// 選擇要出的牌
        /// </summary>
        /// <param name="cards">玩家手上的牌</param>
        /// <returns>選擇的牌</returns>
        public override Card CardSelect(List<Card> cards)
        {
            var command_text = CardSelectCommandText(cards);
            var select = commandLineInterface.Command(command_text);
            var index = Convert.ToInt32(select) - 1;
            var card = cards[index];
            return card;
        }
        /// <summary>
        /// 詢問是否要使用交換手牌特權
        /// </summary>
        /// <returns></returns>
        public override bool UseExchangeHand()
        {
            var command_text = UseExchangeHandText();
            var select = commandLineInterface.Command(command_text);
            return select == "1";
        }
        /// <summary>
        /// 選擇要與哪一位遊戲中的玩家
        /// </summary>
        /// <param name="inGamePlayers">除了自己，遊戲中的玩家</param>
        /// <returns>除了自己，其中一位遊戲中的玩家</returns>
        public override InGamePlayer ExchageHandsSelect(List<InGamePlayer> inGamePlayers)
        {
            var command_text = ExchangeHandSelectText(inGamePlayers);
            var select = commandLineInterface.Command(command_text);
            var index = Convert.ToInt32(select) - 1;
            return inGamePlayers[index];

        }
    }
}
