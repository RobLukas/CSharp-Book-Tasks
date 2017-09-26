using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_7_interface
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            System.Windows.Forms.MessageBox.Show("I'm " + Name + ", have " + Height + " cm height");
        }
    }
}
