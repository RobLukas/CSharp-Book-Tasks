using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_8_zad_8
{
    public partial class Form1 : Form
    {
        Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        public Form1()
        {
            InitializeComponent();
        }

        private void RedrawList()
        {
            int count = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(count + ". " + lumberjack.Name);
                count++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + " ma " + currentLumberjack.FlapjackCount + " naleśników.";
            }
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(name.Text))
            {
                breakfastLine.Enqueue(new Lumberjack(name.Text));
                name.Text = "";
                RedrawList();
            }
            else
            {
                MessageBox.Show("Podaj imię drwala!");
            }
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (crispy.Checked)
                food = Flapjack.Chrupkiego;
            else if (soggy.Checked)
                     food = Flapjack.Wilgotnego;
            else if (browned.Checked)
                    food = Flapjack.Rumianego;
            else
                food = Flapjack.Bananowego;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = "";
        }
    }
}
