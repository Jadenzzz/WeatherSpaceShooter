using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    class FireRight : FireStates
    {
        public FireRight() { }
        public override void UpdateMove(Fire s, float speed)
        {
            SplashKit.SpriteSetX(s.ObjectSprite, SplashKit.SpriteX(s.ObjectSprite) + speed);
        }
        public override void UpdateImage(Fire s)
        {
            s.Image.Free();
            s.Image = SplashKit.LoadBitmap("fire", "FireRight.png");
        }
    }
}
