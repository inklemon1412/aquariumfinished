using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class LakeFish : Fish
    {
        private enum LakeTypes
        {
            Tigerbarb,
            Tilapia,
            Gatorgar,
            Giantstingray

        }
        public LakeFish()
            : base()
        {
            
        }
      public void seeFish()
        {
            var lakefishes = new Dictionary<LakeTypes, LakeFish>
            {
                {LakeTypes.Tigerbarb, new LakeFish{Name = "Tigerbarb ", Desc = "A common freshwater fish known for its black stripes. " , Colour ="Golden" } },
                {LakeTypes.Tilapia, new LakeFish{Name = "Tilapia ", Desc = "A common freshwater fish. Makes for a good meal ",  Colour = "Green" } },
                {LakeTypes.Gatorgar, new LakeFish{Name = "Gator gar ", Desc = "This fish has a long, narrow mouth ", Colour = "Bronze" } },
                {LakeTypes.Giantstingray, new LakeFish{Name = "Giant stingray ", Desc = "A legendary freshwater fish. It’s massive, but it has no bones. The whole body is supported by flexible cartilage", Colour = "Blue" } }
            };
            while (true)
            {
                Console.WriteLine("Press 1 for an overview, 2 for more details");
                var fishMenu = Console.ReadLine();
                switch (fishMenu)
                {
                    case "1":
                        foreach (LakeTypes lakeTypes in Enum.GetValues(typeof(LakeTypes)))
                        {
                            Console.WriteLine(lakeTypes);
                        }
                        break;
                    case "2":
                        foreach (LakeFish f in lakefishes.Values)
                        {
                            Console.WriteLine(f.Name + f.Desc + f.Colour);
                        }
                        break;
                }
            }
        }

       

    }
}

