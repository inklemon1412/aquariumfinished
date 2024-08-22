using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{


    abstract class Fish
    {

       public string Name { get; protected set; }
        public string Desc { get; protected set; }
        public string Colour { get; protected set; }
       
        protected Fish( string name, string desc, string colour)
        {
           Name = name;
            Desc = desc;
            Colour = colour;
          
            
        }
        public abstract void PrintInfo();

       
     

        
    }
}
