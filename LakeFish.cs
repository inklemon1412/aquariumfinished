using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class LakeFish : Fish
    {
        public LakeFish(string name, string desc, string colour)
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

