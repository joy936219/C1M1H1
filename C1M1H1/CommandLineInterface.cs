using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class CommandLineInterface
    {
        public string Command(string command)
        {
            Console.WriteLine($"請選擇你要出的牌");
            Console.WriteLine(command);
            var select = Console.ReadLine();
            return select;
        }
    }
}
