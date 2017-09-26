using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_8_zad_5
{
    public enum DeckNumber
    {
        Deck1 = 1,
        Deck2 = 2
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetDeck(DeckNumber.Deck1);
            ResetDeck(DeckNumber.Deck2);
            RedrawDeck(DeckNumber.Deck1);
            RedrawDeck(DeckNumber.Deck2);
        }

        Deck deck1;
        Deck deck2;
        Random random = new Random();
        public void ResetDeck(DeckNumber deckNumber)
        {
            if (DeckNumber.Deck1 == deckNumber)
            {
                int numberOfCards = random.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    deck1.Add(new Card((Values)random.Next(1, 14), (Suits)random.Next(4)));
                }
                deck1.Sort();
            }
            else
                deck2 = new Deck();
        }

        public void RedrawDeck(DeckNumber deckNumber)
        {
            if (DeckNumber.Deck1 == deckNumber)
            {
                listBox1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                {
                    listBox1.Items.Add(cardName);
                }
                label1.Text = "Zestaw 1. (" + deck1.Count + " kart)";
            }
            else
            {
                listBox2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                {
                    listBox2.Items.Add(cardName);
                }
                label2.Text = "Zestaw 2. (" + deck2.Count + " kart)";
            }
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (deck1.Count >= 1)
                {
                    deck2.Add(deck1.Deal(listBox1.SelectedIndex));
                }
            }
            RedrawDeck(DeckNumber.Deck1);
            RedrawDeck(DeckNumber.Deck2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                if (deck2.Count >= 1)
                {
                    deck1.Add(deck2.Deal(listBox2.SelectedIndex));
                }
            }
            RedrawDeck(DeckNumber.Deck1);
            RedrawDeck(DeckNumber.Deck2);
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(DeckNumber.Deck1);
            RedrawDeck(DeckNumber.Deck1);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(DeckNumber.Deck1);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(DeckNumber.Deck2);
            RedrawDeck(DeckNumber.Deck2);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(DeckNumber.Deck2);
        }
    }
}
