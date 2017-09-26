using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_7
{
    class CardCompare_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit > y.Suit)
            {
                return 1;
            }
            if (x.Suit < y.Suit)
            {
                return -1;
            }
            if (x.Value > y.Value)
            {
                return 1;
            }
            if (x.Value < y.Value)
            {
                return -1;
            }
            return 0;
        }
    }
}
