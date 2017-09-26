using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_7_zad_2
{
    class Room : Location
    {
        private string decoration;
        public Room(string location, string decoration) : base(location)
        {
            this.decoration = decoration;
        }
        public override string Description
        {
            get => base.Description + " Widzisz tutaj " + decoration + ".";
        }
    }
}