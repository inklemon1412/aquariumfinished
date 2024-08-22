using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    
    internal class AquariumSystem 
    {
       

        public void MainSystem()
        {
            OceanAquarium ocean = new OceanAquarium();
            LakeAquarium lake = new LakeAquarium();



            Console.WriteLine("Type 1 for ocean fish, 2 for lake fish");
            var fishmenu = Console.ReadLine();
            switch (fishmenu)
            {
                case "1":
                    ocean.goTo();
                    break;
                case "2":
                    lake.goTo();
                    break;

            }
        }


    }
}