using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_8_zad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(0, 4));
            MessageBox.Show(card.Name);
        }
    }
}
