using BeeHiveManagerV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManager
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber =0;
        public Queen(Worker[] workers, double weightMg):base(weightMg) 
        {
            this.workers = workers;
        }
        public bool AssignWork(string job,int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job,numberOfShifts))
                    return true;
            return false;
        }
        public string WorkTheNextShift()
        {
            double honeyConsumed = HoneyConsumptionRate();
            shiftNumber++;
            string report = "Raport zmiany nr " + shiftNumber + "\r\n";
            report += "Królowa zużyła " + this.HoneyConsumptionRate() + " jednostek miodu\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumed += workers[i].HoneyConsumptionRate();
                if (workers[i].DidYouFinish())
                    report += "Robotnica nr " + (i + 1) + " ukończyła swoje zadanie \r\n";
                  
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Robotnica nr " + (i + 1) + " nie pracuje \r\n";

                else
                if (workers[i].ShiftsLeft > 0)
                    report += "Robotnica nr " + (i + 1) + " robi '" + workers[i].CurrentJob + "' jeszcze przez " + workers[i].ShiftsLeft + " zmiany\r\n";
                else
                    report += "Robotnica nr " + (i + 1) + " skończy '" + workers[i].CurrentJob + "' po tej zmianie\r\n";
            }
            report += "Całkowite spożycie miodu wynosi " + (int)honeyConsumed + " jednostek\r\n";
            return report;
        }
    }
}
