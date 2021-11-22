using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    class B52 : SpaceShip
    {

        public B52() : base()
        {
            Image = SplashKit.LoadBitmap("spaceship", "ship.png");
            ObjectSprite = new Sprite(Image);

        }
        public override void UpdateDirection()
        {
            if (SplashKit.KeyTyped(KeyCode.RKey))
            {
                Dir.dir = Direction.Up;
                this.Image.Free();
                this.Image = SplashKit.LoadBitmap("b52", "ship.png");
            }
            if (SplashKit.KeyTyped(KeyCode.FKey))
            {
                Dir.dir = Direction.Down;
                this.Image.Free();
                this.Image = SplashKit.LoadBitmap("b52d", "shipdown.png");
            }
            if (SplashKit.KeyTyped(KeyCode.DKey))
            {
                Dir.dir = Direction.Left;
                this.Image.Free();
                this.Image = SplashKit.LoadBitmap("b52l", "shipleft.png");
            }
            if (SplashKit.KeyTyped(KeyCode.GKey))
            {
                Dir.dir = Direction.Right;
                this.Image.Free();
                this.Image = SplashKit.LoadBitmap("b52r", "shipright.png");

            }
            
        }
        public override void UpdateSkills() 
        {
            if (this.Score > 1)
            {
                if (SplashKit.KeyTyped(KeyCode.WKey))
                {
                    s.set(new Heal());
                    s.Use(this);

                }
            }

            if (this.Score > 1)
            {
                if (SplashKit.KeyTyped(KeyCode.EKey))
                {
                    s.set(new ThreeShot());
                    s.Use(this);
                }
            }
        }
    }
}
