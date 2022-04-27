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
        public override string DoSelect(string command)
        {
            return commandLineInterface.Command(command);
        }
    }
}
