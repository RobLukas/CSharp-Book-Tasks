using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_8_zad_7
{
    class Player
    {
        private string name;
        public string Name { get => name; }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {

        }
        public Values GetRandomValue()
        {

        }
        public Deck DoYouHaveAny(Values value)
        {

        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {

        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {

        }
        public IEnumerable<Values> PullOutBook()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                        howMany++;
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card++)
                        cards.Deal(card);
                }
            }
            return books;
        }

        public int CardCount { get => cards.Count; }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() => cards.GetCardNames();
        public Card Peek(int cardNumber) => cards.Peek(cardNumber);
        public void SortHand() { cards.SortByValue(); }


    }
}
