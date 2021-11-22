using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    class MainMenu : GameState
    {

        public MainMenu()
        {
        }

        public override void Update(SpaceShooter s)
        {
            SplashKit.DrawText("Welcome to Weather Space Shooter!!!", Color.Black, 50, 150);
            SplashKit.DrawText("Press space to continue!!!", Color.Black, 50, 170);

        }

        public override void ChangeState(SpaceShooter s)
        {
            if (SplashKit.KeyTyped(KeyCode.SpaceKey))
            {
                s.NextState(new Tutorial());
            }
            
        }
    }
}
