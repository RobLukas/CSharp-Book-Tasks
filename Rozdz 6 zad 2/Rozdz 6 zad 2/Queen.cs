using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_6_zad_2
{
    public class Queen : Bee
    {
        private int shiftNumber;
        private Worker[] workers;
        public Queen(Worker[] workers) : base(275)
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
            double totalConsumption = 0;
            string raport = "Raport zmiany numer " + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                totalConsumption += workers[i].GetHoneyConsumption();
            }
            totalConsumption += GetHoneyConsumption();
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
            raport += "Całkowite spożycie miodu: " + totalConsumption + " jednostek.";
            return raport;
        }
        public override double GetHoneyConsumption()
        {
            double largestWorkerConsumption = 0;
            double consumption = 0;
            int workersDoingJob = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption=workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    workersDoingJob++;
            }
            consumption += largestWorkerConsumption;
            if (workersDoingJob >= 3)
            {
                consumption += 30;
            }
            else
            {
                consumption += 20;
            }
            return consumption;
        }
    }
}
