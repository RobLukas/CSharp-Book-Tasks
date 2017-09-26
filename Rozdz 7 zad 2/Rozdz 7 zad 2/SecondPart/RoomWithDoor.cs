using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPart
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string location, string decoration, string doorDescription, string hidingPlaceName) : base(location, decoration, hidingPlaceName)
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