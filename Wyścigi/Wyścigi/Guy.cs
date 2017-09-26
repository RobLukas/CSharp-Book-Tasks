using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścigi
{
    public class Guy
    {
        public string Name;
        public Bet MyBet = null;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public void UpdateLabels()
        {
            if (MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            else
            {
                MyLabel.Text = Name + " nie zawarł zakładu.";
            }

            MyRadioButton.Text = Name + " ma " + Cash;
        }
        public void Clear()
        {
            MyBet = null;
        }
        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount <= Cash)
            {
                MyBet = new Bet();
                MyBet.Amount = Amount;
                MyBet.Dog = Dog;
                MyBet.Bettor = this;
                UpdateLabels();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Collect(int Winner)
        {
            if (MyBet != null)
            {
                Cash += MyBet.PayOut(Winner);
            }
        }
    }
}
