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
            return true;
        }
        public bool LookForEnemies()
        {
            return false;
        }
        public void String(string Enemy) 
        {
            
        }
    }

    public interface IStingPatrol
    {
        public int AlertLevel { get; }
        public int StringLength { get; set; }
        bool LookingForEnemies();
        int SharpenStinger(int Length);
    }

}
