using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    class FireUp : FireStates
    {
        public FireUp()
        {
            
        }

        public override void UpdateMove(Fire s, float speed)
        {
            SplashKit.SpriteSetY(s.ObjectSprite, SplashKit.SpriteY(s.ObjectSprite) - speed);
        }
        public override void UpdateImage(Fire s)
        {
            s.Image.Free();
            s.Image = SplashKit.LoadBitmap("fire", "Fire.png");
        }
    }
}
