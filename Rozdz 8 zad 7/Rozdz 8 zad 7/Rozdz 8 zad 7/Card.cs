using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_7
{
    class Card
    {
        private static string[] names0 = new string[]
        {
            "", "asów", "dwójek", "trójek", "czwórek", "piątek", "szóstek", "siódemek", "ósemek", "dziewiątek", "dziesiątek", "waletów", "dam", "króli"
        };
        private static string[] names1 = new string[]
        {
            "", "asa", "dwójkę", "trójkę", "czwórkę", "piątkę", "szóstkę", "siódemkę", "ósemkę", "dziewiątkę", "dziesiątkę", "waleta", "damę", "króla"
        };
        private static string[] names2AndMore = new string[]
        {
            "", "asy", "dwójki", "trójki", "czwórki", "piątki", "szóstki", "siódemki", "ósemki", "dziewiątki", "dziesiątki", "walety", "damy", "króle"
        };
        private static string[] suits = new string[]
        {
            "pik", "trefl", "karo", "kier"
        };
        private static string[] names = new string[]
        {
            "", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka", "Ósemka", "Dziewiątka", "Dziesiątka", "Walet", "Dama", "Król"
        };

        public static string Plural(Values value, int count)
        {
            if (count == 0)
                return names0[(int)value];
            if (count == 1)
                return names1[(int)value];
            return names2AndMore[(int)value];
        }
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        //public string Name
        //{
        //    get => Value.ToString() + " of " + Suit.ToString();
        //}
        public string Name
        {
            get => names[(int)Value] + " " + suits[(int)Suit];
        }
        public override string ToString() => Name;
    }
    enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Quenn = 12,
        King = 13
    }
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }
}
