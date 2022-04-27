using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1H1
{
    internal class InGamePlayer
    {
        private int _sort;
        private int _point = 0;
        private Player _player;
        private Game _game;
        private List<Card> _hand_cards;
        //private List<GameRounds> _gameRounds;

        public InGamePlayer(Player player, Game game, List<Card> hand_cards, int sort)
        {
            _player = player;
            _game = game;
            _sort = sort;
            _hand_cards = hand_cards;
            //_gameRounds = gameRounds;
        }
       
        public Player player { get => _player; set => _player = value; }
        public Game game { get => _game; set => _game = value; }
        public List<Card> hand_cards {  get => _hand_cards; set => _hand_cards = value;}
        public bool isUseExchangeHands { get; set; } = false;
        public int point { get => _point; set => _point = value;}
        public int sort { get => _sort; set => _sort = value; }

        public Card DrawCard()
        {
            var cards = game.deck.cards;
            var card = cards.FirstOrDefault();
            cards.Remove(card);
            return card;
        }

        public void AddHandCard(Card card)
        {
            hand_cards.Add(card);
        }

        public int CalcPoint()
        {
            //int point = 0;
            //foreach(var round in _gameRounds)
            //{
            //    point += round.point;
            //}
            //return point;]
            return 0;
        }

        public Card Show()
        {
            Card card = new Card();
            var cards =  _hand_cards.Select((s,index) => new  { index = index, cmd = $"{index + 1}", name = Enum.GetName(typeof(Suit), s.Suit) + "-" + Enum.GetName(typeof(Rank), s.Rank).Replace("_","") }  );
            var select = _player.DoSelect(string.Join("\t", cards.Select(n => $"{n.cmd}. {n.name}")));
            var select_index = Convert.ToInt32(select) - 1;
            card = _hand_cards[select_index];
            _hand_cards.RemoveAt(select_index);
            return card;
        }
    }
}
