using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    public class Heal : ISkills
    {
        public Heal()
        {
     
        }

        public void Perform(SpaceShip s)
        {
            s.Hearts +=1;
            s.Score -= 1;
        }
    }
}