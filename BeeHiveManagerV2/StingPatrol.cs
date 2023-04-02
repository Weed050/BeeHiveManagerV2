using BeeHiveManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagerV2
{
    class StingPatrol : Worker
    {
        public StingPatrol(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg)
        {

        }
        public int AlertLevel { get; private set; }
        public int StringLength { get; set; }
        public bool SharpenStinger()
        {

        }
        public bool LookForEnemies()
        {

        }
        public void String(string Enemy) 
        {
            
        }
    }
}
