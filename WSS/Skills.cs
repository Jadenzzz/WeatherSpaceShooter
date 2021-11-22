using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    public class Skills
    {

        private ISkills _skill;
     

        public Skills()
        {
        }

      

        public void Use(SpaceShip s)
        {
            _skill.Perform(s);
        }
        public void set(ISkills s)
        {
            this._skill = s;
        }
       

        
    }
}
