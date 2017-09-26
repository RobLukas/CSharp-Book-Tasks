using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścigi
{
    public partial class Form1 : Form
    {
        Greyhound[] GH = new Greyhound[4];
        Guy[] Bettor = new Guy[3];
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

            int StartPosition = pictureBox1.Location.X;
            int distance = pictureBox1.Width;
            for (int i = 0; i < GH.Length; i++)
            {
                GH[i] = new Greyhound() { Location = StartPosition, MyRandom = random, RacetrackLength = distance };
            }

            GH[0].MyPictureBox = pictureBox2;
            GH[1].MyPictureBox = pictureBox6;
            GH[2].MyPictureBox = pictureBox3;
            GH[3].MyPictureBox = pictureBox4;

            Bettor[0] = new Guy() { Name = "Janek", Cash = 50, MyRadioButton = radioButton1, MyLabel = label4 };
            Bettor[1] = new Guy() { Name = "Bartek", Cash = 75, MyRadioButton = radioButton2, MyLabel = label5 };
            Bettor[2] = new Guy() { Name = "Arek", Cash = 45, MyRadioButton = radioButton3, MyLabel = label6 };

            for (int i = 0; i < Bettor.Length; i++)
            {
                Bettor[i].MyRadioButton.Text = Bettor[i].Name + " ma " + Bettor[i].Cash;
                Bettor[i].MyLabel.Text = " Zakład " + Bettor[i].Name;
            }
            numericUpDown1.Minimum = 5;
            button1.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Label MyLabel = new Label();
            RadioButton MyRadioButton = new RadioButton();
            MinNumer.Text = numericUpDown1.Value + " zł";
            for (int i = 0; i < Bettor.Length; i++)
            {
                if (Bettor[i].MyRadioButton.Checked)
                {
                    Bettor[i].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                }
            }
            numericUpDown1.Minimum = numericUpDown1.Value + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int num_winners = 0;
            int winner = 0;
            for (int i = 0; i < Bettor.Length; i++)
            {
                Bettor[i].UpdateLabels();
            }

            while (num_winners == 0)
            {
                for (int i = 0; i < GH.Length; i++)
                {
                    if (GH[i].Run())
                    {
                        num_winners++;
                        winner = i + 1;
                    }
                }
                System.Threading.Thread.Sleep(3);
            }
            MessageBox.Show("The winner was dog #" + num_winners);
            for (int i = 0; i < GH.Length; i++)
            {
                GH[i].TakeStartingPosition();
            }

            for (int i = 0; i < Bettor.Length; i++)
            {
                Bettor[i].Collect(winner);
                Bettor[i].Clear();
                Bettor[i].UpdateLabels();
            }
            numericUpDown1.Value = numericUpDown1.Minimum;
            numericUpDown2.Value = numericUpDown2.Minimum;
            button2.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
