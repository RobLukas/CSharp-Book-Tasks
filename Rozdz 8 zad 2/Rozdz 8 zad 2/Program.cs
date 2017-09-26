using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> Ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 }
           };
            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            PrintDucks(Ducks);
            //przekazuje metodzie Sort() referencje obiektu DuckComparerBySize jako parametr
            Ducks.Sort(sizeComparer);
            // lub z CompareTo()
            //Ducks.Sort();
            // lub sortowanie według typu
            DuckComparerByKind kindComparer = new DuckComparerByKind();
            //Ducks.Sort(kindComparer);
            DuckComparer comparer = new DuckComparer();

            //ustawiamy pole SortBy, aby zmienić sposób sortowania
            comparer.SortBy = SortCriteria.KindThenSize;
            Ducks.Sort(comparer);

            comparer.SortBy = SortCriteria.SizeThenKind;
            Ducks.Sort(comparer);

            PrintDucks(Ducks);
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                //Console.WriteLine(duck.Size + "-centymetrowa kaczka " + duck.Kind);
                // jeśli do metody WriteLine przekaże referencje do obiektu to automatycznie wywoła się metoda ToString().
                Console.WriteLine(duck);
            }
            Console.WriteLine("Koniec kaczek!\n\n");
        }
    }
}