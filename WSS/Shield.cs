using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaces
{
    public class Shield : ISkills
    {
        public Shield()
        {

        }
        
        public void Perform(SpaceShip s)
        {
            s.shield = true;
        }
    }
}
