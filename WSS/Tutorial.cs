using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    class Tutorial : GameState
    {
        public Tutorial()
        {
            
        }
        
        public override void Update(SpaceShooter s)
        {
            SplashKit.DrawText("Your mission is to achieve the highest score as possible", Color.Red, 10, 150);
            SplashKit.DrawText("To do so you have to destroy the obstacles", Color.Blue, 10, 170);
            SplashKit.DrawText("If you collide with burger you lost 1 heart", Color.Black, 10, 190);
            SplashKit.DrawText("If you collide with stone you lost 3 heart", Color.Black, 10, 210);
            SplashKit.DrawText("If you collide with fireball you will lose", Color.Black, 10, 230);
            SplashKit.DrawText("If you collide with heart you gain 1 heart", Color.Black, 10, 250);
            SplashKit.DrawText("You have 2 skills which is Heal and Three Shot", Color.Black, 10, 270);
            SplashKit.DrawText("Press space to spawn fire", Color.Black, 10, 290);
            SplashKit.DrawText("Press Y to play with Boeing!", Color.Purple, 10, 310);
            SplashKit.DrawText("Press T to play with B52!", Color.Purple, 10, 320);

        }
        public override void ChangeState(SpaceShooter s)
        {
            if (SplashKit.KeyTyped(KeyCode.TKey))
            {
                
                s.NextState(new Playing(new B52()));
            }
            if (SplashKit.KeyTyped(KeyCode.YKey))
            {
                
                s.NextState(new Playing(new Boeing()));
            }

        }
    }
}
