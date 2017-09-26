using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 }
            };
            //rzutowanie listy w góre
            IEnumerable<Bird> upcastDucks = ducks;

            // do listy bird mozna przypisac obiekty typu Duck
            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { Name = "Feathers" });
            // dodajemy jedną listę do drugiej
            birds.AddRange(upcastDucks);
            birds.Add(new Penguin() { Name = "George" });
            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}
