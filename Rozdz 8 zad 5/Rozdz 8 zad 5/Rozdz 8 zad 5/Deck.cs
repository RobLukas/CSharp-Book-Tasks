﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_5
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 0; value <= 13; value++)
                    cards.Add(new Card((Values)value, (Suits)suit));
        }
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }
        public int Count { get => cards.Count; }
        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }
        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }
        public void Shuffle()
        {
            List<Card> NewCard = new List<Card>();
            while (cards.Count > 0)
            {
                int randomIndex = random.Next(cards.Count);
                //Card card = cards[randomIndex];
                NewCard.Add(cards[randomIndex]);
                cards.RemoveAt(randomIndex);
            }
            cards = NewCard;
        }
        // iEnumerable rzutuje liste do góry, kowariancja
        public IEnumerable<string> GetCardNames()
        {
            string[] cardName = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                cardName[i] = cards[i].Name;
            }
            return cardName;
        }
        public void Sort()
        {
            cards.Sort(new CardCompare_byValue());
        }
    }
}