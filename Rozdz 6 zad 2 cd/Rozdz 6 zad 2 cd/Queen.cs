using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_6_zad_2_cd
{
    public class Queen
    {
        private int shiftNumber;
        private Worker[] workers;
        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }
        public bool AssignWork(string job, int numberOfShift)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, numberOfShift))
                    return true;
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string raport = "Raport zmiany numer " + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    raport += "Robotnica numer " + (i + 1) + " zakończyła swoje zadanie\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    raport += "Robotnica numer " + (i + 1) + " nie pracuje\r\n";
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                        raport += "Robotnica numer " + (i + 1) + " robi " + workers[i].CurrentJob + " jeszcze przez " + workers[i].ShiftsLeft + " zmian\r\n";
                    else
                        raport += "Robotnica numer " + (i + 1) + " zakończy " + workers[i].CurrentJob + " po tej zmianie\r\n";
                }
            }
            return raport;
        }
    }
}
