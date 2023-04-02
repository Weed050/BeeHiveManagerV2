using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagerV2
{
    class NectarStinger: Bee ,IStingPatrol,INectarCollector
    {
        public int Nectar { get; set; }
        public int AlertLevel { get; private set; }
        public int StringLength { get; set; }


        public NectarStinger(double weightMg):base(weightMg)
        {
            
        }

        public void FindFlower()
        {

        }
        public void GatherNectar()
        {

        }
        public void ReturnToHive()
        {

        }
        public int SharpenStinger(int Length)
        {
            return 1;
        }
        public bool LookingForEnemies()
        {
            return false;
        }
    }
}
