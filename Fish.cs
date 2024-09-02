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

        private string fishName;
        private string fishDesc;
        private string fishColour;


    

    public string Name
    {
        get { return fishName;  }
        set { fishName = value; }
    }

      public string Desc
        {
            get { return fishDesc; }
            set { fishDesc = value; }
        }
    public string Colour
        {
            get { return fishColour; }
            set { fishColour = value; }
        }
        

       
       



    }
}
