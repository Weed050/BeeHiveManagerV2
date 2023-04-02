using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagerV2
{
    class NectarCollector : Bee
    {
        public NectarCollector(double weightMg):base(weightMg)
        {
            
        }
        public int Nectar { get; set; }
        public void FindFlowers()
        {

        }
        public void GatherNectar()
        {

        }
        public void ReturnToHive()
        {

        }


    }

    public interface INectarCollector
    {
        void FindFlower();
        void GatherNectar();
        void ReturnToHive();
    }
    }
