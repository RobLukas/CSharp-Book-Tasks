using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cards = new List<Card>();
            Console.WriteLine("Pięć losowych kart\n");

            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Values)random.Next(1, 14), (Suits)random.Next(0, 3)));
                Console.WriteLine(cards[i].Name);
            }
            Console.WriteLine("\nLista kart po sortowaniu:\n");
            CardCompare_byValue cardCompare = new CardCompare_byValue();
            cards.Sort(cardCompare);
            foreach (Card cardSort in cards)
            {
                Console.WriteLine(cardSort);
            }
        }
    }
}
