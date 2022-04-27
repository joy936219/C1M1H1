using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class AI_Player : Player
    {
        public override string DoSelect(string command)
        {
            var rnd_select = command.Split('\t');
            var length = rnd_select.Length;
            return new Random().Next(1, length+1).ToString();
        }
    }
}
