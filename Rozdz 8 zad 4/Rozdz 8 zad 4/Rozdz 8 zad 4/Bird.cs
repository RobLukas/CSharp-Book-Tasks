using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_4
{
    class Bird
    {
        public string Name { get; set; }
        public virtual void Fly() { Console.WriteLine("Frr... frr..."); }
        public override string ToString() => "Ptak " + Name;
    }
}
