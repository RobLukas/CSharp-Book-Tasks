using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPart
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string location, bool hot, string hidingPlaceName) : base(location, hot)
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
