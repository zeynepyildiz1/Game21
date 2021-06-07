﻿using System;
using Game21.Entities;
namespace Game21
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck<Card> deck1 = new Deck<Card>();
            var deckList1 = deck1.createDeck();
            foreach (var item in deckList1)
            {
                Console.WriteLine("Kart " + item.Suit + " " + item.CardNumber);
            }
            Console.WriteLine("Kart sayisi: " + deckList1.Count);


            Deck<Game21Card> deck2 = new Deck<Game21Card>();
            var deckList2 = deck2.createDeck();
            foreach (var item in deckList2)
            {
                Console.WriteLine("Kart " + item.Suit + " " + item.CardNumber + " degeri " + string.Join(",", item.Values));
            }
            Console.WriteLine("Kart sayisi: " + deckList1.Count);
        }
    }
}
