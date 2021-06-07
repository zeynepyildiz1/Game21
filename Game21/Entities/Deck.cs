﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game21.Entities
{
    public class Deck<TCard> : IEntity where TCard : class,  new()
    {
        public Deck()
        {
            createDeck();
        }

        public List<TCard> Cards { get; set; }

   
        
        public List<TCard> createDeck()
        {
            TCard t = new TCard();
           Cards = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13)
                                    .Select(c => (TCard)Activator.CreateInstance(typeof(TCard), (Suit)s, (CardNumber)c)))
                   .ToList();
            return Cards;

        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid())
                         .ToList();
        }

        public TCard TakeCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card);

            return card;
        }

        public IEnumerable<TCard> TakeCards(int numberOfCards)
        {
            var cards = Cards.Take(numberOfCards);

            var takeCards = cards as TCard[] ?? cards.ToArray();
            Cards.RemoveAll(takeCards.Contains);

            return takeCards;
            }
        }
}