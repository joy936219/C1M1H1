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
        private bool _isUseExchangeHands = false;
        private Player _player;
        private Game _game;
        private List<Card> _hand_cards;
        private Exchange_Hands _exchage_hands;
        //private List<GameRounds> _gameRounds;

        public InGamePlayer(Player player, Game game, List<Card> hand_cards , int sort)
        {
            _player = player;
            _game = game;
            _sort = sort;
            _hand_cards = hand_cards;
        }
       
        public Player player { get => _player; set => _player = value; }
        public Game game { get => _game; set => _game = value; }
        public List<Card> hand_cards {  get => _hand_cards; set => _hand_cards = value;}
        public bool isUseExchangeHands { get => _isUseExchangeHands; set => _isUseExchangeHands = value; }
        public int point { get => _point; set => _point = value;}
        public int sort { get => _sort; set => _sort = value; }
        public Exchange_Hands exchange_hands { get => _exchage_hands;}
        /// <summary>
        /// 玩家抽牌
        /// </summary>
        /// <returns>抽到的牌</returns>
        public Card DrawCard()
        {
            var cards = game.deck.cards;
            var card = cards.FirstOrDefault();
            cards.Remove(card);
            return card;
        }
        /// <summary>
        /// 加入玩家的手牌上
        /// </summary>
        /// <param name="card">抽到的牌</param>
        public void AddHandCard(Card card)
        {
            hand_cards.Add(card);
        }
        /// <summary>
        /// 玩家得分加1分
        /// </summary>
        public void GainPoint()
        {
            _point += 1;
        }
        /// <summary>
        /// 玩家選擇一張牌出牌
        /// </summary>
        /// <returns></returns>
        public Card Show()
        {
            var select = _player.CardSelect(_hand_cards);
            _hand_cards.Remove(select);
            return select;
        }
        /// <summary>
        /// 詢問玩家是否要使用交換手牌特權
        /// </summary>
        public void UseExchangeHands()
        {
            if (!_isUseExchangeHands)
            {
                if(_player.UseExchangeHand())
                {
                    var excahange_players = game.inGamePlayers.Where(p => p.sort != this.sort).ToList();
                    var select_player = _player.ExchageHandsSelect(excahange_players);
                    Exchange_Hands exchange_Hands = new Exchange_Hands(this,select_player);
                    _exchage_hands = exchange_Hands;
                    _exchage_hands.ExchangeHand();
                    _isUseExchangeHands = true;                    
                }
               
            }
           
        }
    }
}
