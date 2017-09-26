using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_7_zad_2
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string location, string decoration, string doorDescription) : base(location, decoration)
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
    }
}