using System;
using System.Collections.Generic;
using System.Text;

namespace Game21.Entities
{
    public class Game21Card:Card , IEntity
    {
        private int[] _values;
        public int[] Values { get { return _values; } }

        public Game21Card() : base() { }

        public Game21Card(Suit suit, CardNumber cardNumber) : base(suit, cardNumber)
        {
            if (cardNumber == CardNumber.Ace)
            {
                _values = new int[2] { (int)cardNumber, (int)cardNumber + (int)CardNumber.Ten };
            }
            if (cardNumber == CardNumber.Queen || cardNumber==CardNumber.King || cardNumber==CardNumber.Jack)
            {
                _values = new int[1] { (int)CardNumber.Ten };
            }
            else
            {
                _values = new int[1] { (int)cardNumber };
            }
        }
    }
}
