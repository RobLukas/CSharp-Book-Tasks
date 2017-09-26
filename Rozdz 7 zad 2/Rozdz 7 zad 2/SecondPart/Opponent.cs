using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPart
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location myLocation)
        {
            this.myLocation = myLocation;
            random = new Random();
        }

        public void Move()
        {
            if (myLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor LocationWithDoor = myLocation as IHasExteriorDoor;
                if (random.Next(2) == 1)
                    myLocation = LocationWithDoor.DoorLocation;

                bool hiding = true;
                while (hiding)
                {
                    int rand = random.Next(myLocation.Exits.Length);
                    myLocation = myLocation.Exits[rand];
                    if (myLocation is IHidingPlace)
                        hiding = false;
                }
            }
        }
        public bool Check(Location checkLocation)
        {
            if (myLocation != checkLocation)
                return false;
            else
                return true;
        }
    }
}