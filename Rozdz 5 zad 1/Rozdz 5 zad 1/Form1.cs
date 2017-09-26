using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_5_zad_1
{

    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            DinnerParty dinner = new DinnerParty(5, true, true);
            decimal cost1 = dinner.CalculateCost(true);
            decimal cost2 = dinner.CalculateCost();
            dinnerParty = new DinnerParty((int)NumericUpDownPeopleOfNumber.Value, FancyCheckBox.Checked, HealthyCheckBox.Checked);
            DisplayDinnePartyCost();
            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }
        private void DisplayBirthdayPartyCost()
        {
            cakeWriting.Text = birthdayParty.CakeWriting;
            decimal cost = birthdayParty.CalculateCost();
            birthdayCost.Text = cost.ToString("c");
        }
        private void DisplayDinnePartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(HealthyCheckBox.Checked);

            costLabel.Text = Cost.ToString("c");
        }

        private void NumericUpDownPeopleOfNumber_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)NumericUpDownPeopleOfNumber.Value;
            DisplayDinnePartyCost();
        }
        private void FancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(FancyCheckBox.Checked);
            DisplayDinnePartyCost();
        }
        private void HealthyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthlyOption(HealthyCheckBox.Checked);
            DisplayDinnePartyCost();
        }
        private void NumberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }
        private void FancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            DisplayBirthdayPartyCost();
        }
        private void CakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
