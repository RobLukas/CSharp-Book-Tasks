using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_4_zad_2
{
    public class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają " + EarSize + " centymetrow szerokosci.", Name + " mowi...");
        }
    }
}
