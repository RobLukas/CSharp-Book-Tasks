using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Dziękuje za zwrócenie klejnotów! " + safeContents.Sparkle());
        }
    }
}
