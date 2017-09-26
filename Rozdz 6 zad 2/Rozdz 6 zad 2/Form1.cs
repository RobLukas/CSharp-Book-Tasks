﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozdz_6_zad_2
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" }, 175);
            workers[1] = new Worker(new string[] { "Pięlegnacja jaj", "Nauczanie pszczółek" }, 114);
            workers[2] = new Worker(new string[] { "Utrzymanie ula", "Patrol z żądłami" }, 149);
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pięlegnacja jaj", "Nauczanie pszczółek", "Utrzymanie ula", "Patrol z żądłami" }, 155);
            queen = new Queen(workers);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {

            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
            {
                MessageBox.Show("Nie ma dostępnych robotnic do wykonania zadania '" + workerBeeJob.Text + "'", "Królowa pszczół mówi...");
            }
            else
            {
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' będzie ukończone za " + shifts.Value + " zmiany", "Królowa pszczół mówi...");
            }
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}