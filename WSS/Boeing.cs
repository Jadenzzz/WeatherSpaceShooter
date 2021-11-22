using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    class Boeing : SpaceShip
    {
        public Boeing() 
        {
            Image = SplashKit.LoadBitmap("bu", "secondship.png");
            ObjectSprite = new Sprite(Image);
            
        }
        public override void UpdateDirection()
        {
            if (SplashKit.KeyTyped(KeyCode.RKey))
            {
                Dir.dir = Direction.Up;
                this.Image.Free();
                this.Image = SplashKit.LoadBitmap("bu", "secondship.png");
            }
            if (SplashKit.KeyTyped(KeyCode.FKey))
            {
                Dir.dir = Direction.Down;
                this.Image.Free();
                this.Image = SplashKit.LoadBitmap("bd", "secondshipDown.png");
            }
            if (SplashKit.KeyTyped(KeyCode.DKey))
            {
                Dir.dir = Direction.Left;
                this.Image.Free();
                this.Image = SplashKit.LoadBitmap("bl", "secondshipLeft.png");
            }
            if (SplashKit.KeyTyped(KeyCode.GKey))
            {
                Dir.dir = Direction.Right;
                this.Image.Free();
                this.Image = SplashKit.LoadBitmap("br", "secondshipRight.png");

            }
            else
            {

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
                    s.set(new Shield());
                    s.Use(this);
                }
            }
        }
        //<summay>
        //  Boeing will have its unique draw method because it has skills that will draw circle around the ship
        //</summary>
        public override void Draw()
        {
            if (shield == false)
            {
                SplashKit.DrawSprite(this.ObjectSprite);
            }
            else
            {
                SplashKit.DrawSprite(this.ObjectSprite);
                if (Dir.dir == Direction.Up || Dir.dir == Direction.Down)
                {
                    SplashKit.DrawCircle(Color.Blue, this.X + this.Width / 2, this.Y + this.Height / 2, this.Width / 2);
                }
                if (Dir.dir == Direction.Left || Dir.dir == Direction.Right)
                {
                    SplashKit.DrawCircle(Color.Blue, this.X + this.Width / 2, this.Y + this.Height / 2, this.Height / 2);
                }

            }
        }
    }
}
