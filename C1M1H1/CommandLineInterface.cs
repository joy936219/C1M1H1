using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class CommandLineInterface
    {
        /// <summary>
        /// 指令介面
        /// </summary>
        /// <param name="command">輸入指令介面文字</param>
        /// <param name="max_cmd_number">最大指令的數字</param>
        /// <returns></returns>
        private string Command(string command, int max_cmd_number)
        {
            int num=0;
            bool success=true;
            string select;
            do
            {   
                if(!success || (success && num > max_cmd_number))
                {
                    Console.WriteLine("輸入錯誤，請重新選擇  \r\n");
                }
                Console.WriteLine($"{command} \r\n");
                select = Console.ReadLine();
                success = int.TryParse(select, out num);
            } while (!success || (success && num > max_cmd_number));
           
            return select;
        }

        /// <summary>
        /// 給指令介面的文字 : 是否要使用交換手牌特權
        /// </summary>
        /// <returns></returns>
        public string UseExchangeHandCommand()
        {
            var command = $"是否要使用交換手牌特權? 1.是\t2.否";
            return Command(command,2);
        }
        /// <summary>
        /// 給指令介面的文字 : 請選擇你要交換手牌的玩家
        /// </summary>
        /// <param name="inGamePlayers">除了自己，遊戲中的玩家</param>
        /// <returns></returns>
        public string ExchangeHandSelectCommand(List<InGamePlayer> inGamePlayers)
        {
            var players_name = inGamePlayers.Select((p, index) => $"{index + 1}. {p.player.name}");
            var command = $"請選擇你要交換手牌的玩家\r\n" + String.Join("\t", players_name);
            return Command(command, inGamePlayers.Count());
        }
        /// <summary>
        /// 給指令介面的文字 : 請選擇你要出的牌
        /// </summary>
        /// <param name="cards">玩家手上的牌</param>
        /// <returns></returns>
        public string CardSelectCommand(List<Card> cards)
        {
            var _cards = cards.Select((s, index) => new { index = index, cmd = $"{index + 1}", name = Enum.GetName(typeof(Suit), s.Suit) + "-" + Enum.GetName(typeof(Rank), s.Rank).Replace("_", "") });
            var command = $"請選擇你要出的牌\r\n" + string.Join("\t", _cards.Select(n => $"{n.cmd}. {n.name}"));
            return Command(command, cards.Count());
        }
    }
}
