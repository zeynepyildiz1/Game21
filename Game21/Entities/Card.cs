using System;
using System.Collections.Generic;
using System.Text;

namespace Game21.Entities
{
    public class Card:IEntity
    {
        public Guid Id { get; set; }
        public Suit Suit { get; set; }
        public CardNumber CardNumber { get; set; }
        public Card(Suit suit,CardNumber cardNumber)
        {
            this.Suit = suit;
            this.CardNumber = cardNumber;
        }

        public Card()
        {

        }
    }
}
