using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class Deck
    {
        private List<Card> _cards;

        public Deck()
        {
            _cards = new List<Card>();
            //Club
            _cards.Add(new Card { Rank = Rank._2, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank._3, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank._4, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank._5, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank._6, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank._7, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank._8, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank._9, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank._10, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank.J, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank.Q, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank.K, Suit = Suit.Club });
            _cards.Add(new Card { Rank = Rank.A, Suit = Suit.Club });
            //Diamond
            _cards.Add(new Card { Rank = Rank._2, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank._3, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank._4, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank._5, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank._6, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank._7, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank._8, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank._9, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank._10, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank.J, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank.Q, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank.K, Suit = Suit.Diamond });
            _cards.Add(new Card { Rank = Rank.A, Suit = Suit.Diamond });
            //Heart
            _cards.Add(new Card { Rank = Rank._2, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank._3, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank._4, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank._5, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank._6, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank._7, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank._8, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank._9, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank._10, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank.J, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank.Q, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank.K, Suit = Suit.Heart });
            _cards.Add(new Card { Rank = Rank.A, Suit = Suit.Heart });
            //Spade
            _cards.Add(new Card { Rank = Rank._2, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank._3, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank._4, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank._5, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank._6, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank._7, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank._8, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank._9, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank._10, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank.J, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank.Q, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank.K, Suit = Suit.Spade });
            _cards.Add(new Card { Rank = Rank.A, Suit = Suit.Spade });
        }

        public List<Card> cards { get => _cards; set => _cards = value; }
        /// <summary>
        /// 牌堆開始洗牌
        /// </summary>
        public void Shuffle()
        {
            Console.WriteLine($"牌堆開始洗牌 \r\n");
            var shuffle = _cards.OrderBy(c => Guid.NewGuid()).ToList();
            _cards.Clear();
            _cards.AddRange(shuffle);
        }
    }
}
