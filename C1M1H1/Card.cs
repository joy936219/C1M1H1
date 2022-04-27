using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class Card
    {
       public Rank Rank { get; set; }
       public Suit Suit { get; set; }
    }

    public enum Rank
    {
        _2 = 1,
        _3 = 2,
        _4 = 3,
        _5 = 4,
        _6 = 5,
        _7 = 6,
        _8 = 7,
        _9 = 8,
        _10 = 9,
        J = 10,
        Q = 11,
        K = 12,
        A = 13,
    }

    public enum Suit
    {
        Club = 1,
        Diamond = 2,
        Heart = 3,
        Spade = 4
    }
}
