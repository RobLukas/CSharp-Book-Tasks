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
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            cards = new Deck(new Card[] { });
            textBoxOnForm.Text = Name + " dołączył do gry.\r\n";
        }
        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
            //sprawdzić
            //Values randomCard = cards.Peek(random.Next(cards.Count)).Value;
            //return randomCard;
        }
        public Deck DoYouHaveAny(Values value)
        {
            Deck cardsIHave = cards.PullOutValue(value);
            textBoxOnForm.Text += Name + " ma " + cardsIHave.Count + " " + Card.Plural(value, cardsIHave.Count) + Environment.NewLine;
            return cardsIHave;
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            Values randomValue = GetRandomValue();
            AskForACard(players, myIndex, stock, randomValue);
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += Name + " pyta, czy ktoś ma " + Card.Plural(value, 1) + Environment.NewLine;
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck CardGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardGiven.Count;
                    while (CardGiven.Count > 0)
                        TakeCard(CardGiven.Deal());
                }
            }
            if (totalCardsGiven == 0)
            {
                textBoxOnForm.Text += Name + " pobrał kartę z kupki" + Environment.NewLine;
                TakeCard(stock.Deal());
            }
        }
        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < CardCount; card++)
                {
                    if (cards.Peek(card).Value == value)
                        howMany++;
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--)
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
