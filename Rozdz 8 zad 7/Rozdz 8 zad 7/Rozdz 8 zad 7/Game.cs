using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_8_zad_7
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }
        public void Deal()
        {
            stock.Sort();
            for (int i = 0; i < 5; i++)
                foreach (Player player in players)
                    player.TakeCard(stock.Deal());
            foreach (Player player in players)
                PullOutBooks(player);
        }
        public bool PlayOneRound(int selectedPlayerCard)
        {

        }
        public bool PullOutBooks(Player player)
        {

        }
        public string DescribeBooks()
        {

        }
        public string GetWinnerName()
        {

        }
        public IEnumerable<string> GetPlayerCardName() => players[0].GetCardNames();
        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " ma " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " kartę." + Environment.NewLine;
                else if (players[i].CardCount == 2 || players[i].CardCount == 3)
                    description += " karty." + Environment.NewLine;
                else
                    description += " kart." + Environment.NewLine;
            }
            description += "Na kupce pozostało kart: " + stock.Count + Environment.NewLine;
            return description;
        }
    }
}