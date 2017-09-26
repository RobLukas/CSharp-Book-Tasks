using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_6_zad_2_cd
{
    public class Worker
    {
        private string[] jobICanDo;
        private int shiftToWork;
        private int shiftWorked;

        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public Worker(string[] jobICanDo)
        {
            this.jobICanDo = jobICanDo;
        }
        public int ShiftsLeft
        {
            get
            {
                return shiftToWork - shiftWorked;
            }
        }
        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!string.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            for (int i = 0; i < jobICanDo.Length; i++)
            {
                if (jobICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftToWork = numberOfShifts;
                    shiftWorked = 0;
                    return true;
                }
            }
            return false;
        }
        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            shiftWorked++;
            if (shiftWorked > shiftToWork)
            {
                shiftWorked = 0;
                shiftToWork = 0;
                currentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
