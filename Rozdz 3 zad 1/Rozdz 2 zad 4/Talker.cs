using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_2_zad_4
{
    class Talker
    {
        public static int Blabla(string thingToSay, int numberOfTime)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTime; count++)
            {
                finalString = finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        } 
    }
}
