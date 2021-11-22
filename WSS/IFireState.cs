using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    public interface IFireState
    {
        public void ChangeState(Fire s) { }
        public void UpdateMove(Fire s, float speed) {}
        public void UpdateImage(Fire s) { }
    }
}
