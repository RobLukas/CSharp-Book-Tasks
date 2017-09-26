using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Wyścigi
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;
        int StartMeta = 16;
        public bool Run()
        {
            int distance = 0;
            distance = MyRandom.Next(1, 4);
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            if (p.X > RacetrackLength - 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TakeStartingPosition()
        {
            Point p = MyPictureBox.Location;
            p.X = StartMeta;
            MyPictureBox.Location = p;
        }
    }
}
