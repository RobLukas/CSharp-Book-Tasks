using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_8_zad_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        public string Name
        {
            get => Value.ToString() + " of " + Suit.ToString();
        }
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
