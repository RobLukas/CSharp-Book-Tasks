using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_4_zad_1
{
    public partial class Form1 : Form
    {
        public int startingMileage;
        public int endingMileage;
        public double milesTraveled;
        public double reinburseRate = 0.39;
        public double amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int) numberStart.Value;
            endingMileage = (int) numberEnd.Value;
            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage -= startingMileage;
                amountOwed = milesTraveled *= reinburseRate;
                label4.Text = amountOwed.ToString() + " zł";
            }
            else
            {
                MessageBox.Show("Poczatkowy stan musi byc mniejszy niz koncowy", "Nie moge obliczyc odleglosci");
            }
        }
    }
}
