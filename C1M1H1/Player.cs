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

        public string name { get => _name; set { _name = value;} }

        public abstract string DoSelect(string command);
        public void Name_himself(string name)
        {
            _name = name;
        }
    }
}
