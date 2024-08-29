using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class OceanFish : Fish
    {

        private enum OceanTypes
        {
            Lobster,
            Jellyfish,
            Parrotfish,
            Lionfish,
            GreatWhite

        }


        public OceanFish()
             : base("", "", "")
        {


        }

        public void seeFish()
        {

            var oceanFishes = new Dictionary<OceanTypes, OceanFish>
            {
                {OceanTypes.Lobster, new OceanFish {Name ="Lobster ", Desc ="Commonly found near the pier ", Colour = "Red" } },
              {OceanTypes.Jellyfish,  new OceanFish{ Name = "Jellyfish ", Desc = "Cute, but venomous and dangerous ", Colour = "Light blue" } },
               {OceanTypes.Parrotfish, new OceanFish{ Name = "Parrotfish ", Desc = "It hunts during the day and sleeps at night in a self-built mucus cocoon ", Colour = "blue, orange and green" } },
               {OceanTypes.Lionfish, new OceanFish{ Name = "Lionfish ", Desc ="It likes warm water. Commonly found in the Summer. ",   Colour = "Yellow" } },
                {OceanTypes.GreatWhite,  new OceanFish {Name = "Great White ", Desc ="A legendary saltwater fish. The apex predator of the ocean. ", Colour = "Gray" } }
            };
            while (true)
            {
                Console.WriteLine("Press 1 for an overview, 2 for more details");
                var fishMenu = Console.ReadLine();
                switch (fishMenu)
                {
                    case "1":
                        foreach (OceanTypes oceanTypes in Enum.GetValues(typeof(OceanTypes)))

                        {

                            Console.WriteLine(oceanTypes);

                        }
                        break;
                    case "2":
                        foreach (OceanFish f in oceanFishes.Values)
                        {
                            Console.WriteLine(f.Name + f.Desc + f.Colour);
                        }
                        break;
                }
            }
        }
    }
}
    
           

           
 


        
    


      

       
        


       

