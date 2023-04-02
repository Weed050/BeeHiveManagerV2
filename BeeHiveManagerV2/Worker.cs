﻿using BeeHiveManagerV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManager
{
    class Worker : Bee
    {
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        private string currentJob = "";
        const double HoneyUnitsPerShiftWorked = .65;
        public Worker(string[] jobsICanDo, double weightMg):base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }
        public int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
        }
        public string CurrentJob
        {
            get { return currentJob; }
        }
        public bool DoThisJob(string job,int numberOfShifts)
        {
            if (!string.IsNullOrEmpty(CurrentJob)) 
                return false;

                for (int i = 0; i < jobsICanDo.Length; i++) // jobsICanDo to tablica
            {
                    if (jobsICanDo[i] == job)
                    {
                        currentJob = job;
                        this.shiftsToWork = numberOfShifts;
                        shiftsWorked = 0;
                        return true;
                    }
                }
                    return false;
        }
        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                currentJob = "";
                return true;
            }
            else
            return false;
        }
        public override double HoneyConsumptionRate()
        {
            return base.HoneyConsumptionRate()+(shiftsWorked*HoneyUnitsPerShiftWorked);
        }
    }
}
