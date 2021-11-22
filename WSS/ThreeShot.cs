using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaces
{
    class ThreeShot : ISkills
    {
        public ThreeShot()
        {

        }

        public void Perform(SpaceShip s)
        {
            
                s.threeshot = true;
            
            
        }
    }

}
