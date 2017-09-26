using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPart
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        
        public OutsideWithDoor(string location, bool hot, string doorDescription) : base(location, hot)
        {
            this.doorDescription = doorDescription;
        }

        private Location doorLocation;
        public Location DoorLocation
        {
            get => doorLocation;
            set { doorLocation = value; }
        }

        private string doorDescription;
        public string DoorDescription
        {
            get => doorDescription;
        }
        public override string Description => base.Description + " Widzisz teraz " + doorDescription + ".";
    }
}