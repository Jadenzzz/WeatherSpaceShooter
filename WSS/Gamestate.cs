using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaces
{
    public abstract class GameState : IState
    {

        public GameState()
        {
        }
       

        public virtual void ChangeState(SpaceShooter s)
        {}
 
        public virtual void Update(SpaceShooter s) { }
        
    }
}
