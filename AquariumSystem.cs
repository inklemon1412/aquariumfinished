using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    
    internal class AquariumSystem 
    {
        
        public void MainSystem()
        {
           
            LakeFish lake = new LakeFish();
            OceanFish ocean = new OceanFish();


            Console.WriteLine("Type 1 for ocean fish, 2 for lake fish");
            var fishmenu = Console.ReadLine();
            switch (fishmenu)
            {
                case "1":
                    ocean.seeFish();
                    break;
                case "2":
                    lake.seeFish();
                    break;
                   
            }
        }
        

    }
}