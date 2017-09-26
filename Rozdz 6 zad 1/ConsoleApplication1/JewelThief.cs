using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("Kradnę zawartość sejfu!" + stolenJewels.Sparkle());
        }
    }
}
