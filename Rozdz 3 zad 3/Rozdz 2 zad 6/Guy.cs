using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_2_zad_6
{
    public class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("I dont have enough money to give you " + amount, Name + "said...");
                return 0;
            }
        }
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " this is not amount of money that i can take ", Name + " said...");
                return 0;
            }
        }
    }
}
