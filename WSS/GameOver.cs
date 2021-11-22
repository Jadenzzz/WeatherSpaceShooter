using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    class GameOver : GameState
    {
        public GameOver() 
        {
        }
        public override void Update(SpaceShooter s)
        {
            SplashKit.DrawText("Game Over", Color.Black, 70, 150);
            SplashKit.DrawText("Your Score: " + Playing.s.Score, Color.Black, 70, 170);
            SplashKit.ShowMouse();
        }
        public override void ChangeState(SpaceShooter s)
        {
        }
    }
}
