using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_2
{
    class DuckComparerByKind : IComparer<Duck>
    {
        // sortuje według typu wyliczeniowego Kind porównując ich wartości po indeksie
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
            {
                return -1;
            }
            if (x.Kind > y.Kind)
            {
                return 1;
            }
            return 0;
        }
    }
}
