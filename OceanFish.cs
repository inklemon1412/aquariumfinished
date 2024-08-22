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
        public OceanFish(string name, string desc, string colour)
             : base(name, desc, colour)
        {

        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Desc}");
            Console.WriteLine($"Colour:{Colour}");
        }
    }
}
