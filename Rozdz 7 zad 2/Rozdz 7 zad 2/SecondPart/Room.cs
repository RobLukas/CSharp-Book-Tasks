using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPart
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