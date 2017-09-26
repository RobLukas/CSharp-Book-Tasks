using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_2_zad_6
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();

            bob = new Guy() { Cash = 50, Name = "Joe" };
            joe = new Guy() { Cash = 100, Name = "Bob" };
            Update();
        }

        public void Update()
        {
            joeCash.Text = joe.Name + " have " + joe.Cash + " zl";
            bobCash.Text = bob.Name + " have " + bob.Cash + " zl";
            bankCash.Text = "Bank have " + bank + " zl";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                Update();
            }
            else
            {
                MessageBox.Show("Bank dont have such a amount of money");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            Update();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            Update();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            Update();
        }
    }
}
