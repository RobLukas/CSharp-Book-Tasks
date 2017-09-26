using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_4
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Pingwiny nie latają");
        }
        public override string ToString() => "Pingwin " + base.Name;
    }
}
