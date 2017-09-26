using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_2_zad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj", "RŁ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Talker.Blabla(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("Długość wiadomości to " + len);
        }
    }
}
