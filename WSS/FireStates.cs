using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    public abstract class FireStates : IFireState
    {
        public FireStates(){}
        public void ChangeState(Fire s)
        {
            if (Dir.dir == Direction.Up)
            {
                s.NextState(new FireUp());
            }
            if (Dir.dir == Direction.Down)
            {
                s.NextState(new FireDown());
            }
            if (Dir.dir == Direction.Left)
            {
                s.NextState(new FireLeft());
            }
            if (Dir.dir == Direction.Right)
            {
                s.NextState(new FireRight());
            }
        }
        public virtual void UpdateMove(Fire s, float speed) 
        {
        }
        public virtual void UpdateImage(Fire s)
        { }
    }
}
