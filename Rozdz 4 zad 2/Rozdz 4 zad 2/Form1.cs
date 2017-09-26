using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_4_zad_2
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lioyd;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lioyd = new Elephant() { Name = "Lioyd", EarSize = 40 };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lioyd.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant Change;
            Change = lucinda;
            lucinda = lioyd;
            lioyd = Change;
            MessageBox.Show("Obiekty zmienione");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lioyd = lucinda;
            lioyd.EarSize = 2312;
            lioyd.WhoAmI();
        }
    }
}
