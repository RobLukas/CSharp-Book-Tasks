using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPart
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string location, string decoration, string hidingPlaceName) : base(location, decoration)
        {
            this.hidingPlaceName = hidingPlaceName;
        }


        private string hidingPlaceName;
        public string HidingPlaceName
        {
            get => hidingPlaceName;
        }
    }
}
