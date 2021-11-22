using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace spaces
{
    public abstract class SpaceShip : GameObjects
    {
        private int _hearts = 1;
        private int _score = 2;
        protected Skills s;
        public bool threeshot = false;
        public bool shield = false;
        public int Hearts { get { return _hearts; } set { _hearts = value; } }
        public int Score { get { return _score; } set { _score = value; } }
        


        public SpaceShip() : base()
        {
            SplashKit.SpriteSetX(ObjectSprite, SplashKit.MouseX() - Width / 2);
            SplashKit.SpriteSetY(ObjectSprite, SplashKit.MouseY() - Height / 2);
            s = new Skills();
            Dir.dir = Direction.Up;
        }

        
        //<summary>
        // move update for space ship, the space ship w
        //</summary>
        public void UpdateMove()
        { 
            // spaceship position will update according to mouse position
            float x = SplashKit.MouseX() - Width / 2;
            float y = SplashKit.MouseY() - Height / 2;
            if (x > 600 - Image.Width) 
            { 
                x = 600 - Image.Width; 
            }
            else if (x < 0 - Image.Width) {
                x = 0; 
            }
            if (y > 800 - Image.Height) 
            { 
                y = 800 - Image.Height; 
            }
            else if (y < 0)
            { 
                y = 0; 
            }
            SplashKit.SpriteSetX(ObjectSprite, x);    
            SplashKit.SpriteSetY(ObjectSprite, y);
        }
        //<summay>
        //  Each kind of space ship will have their own image when changing direction
        //</summary>
        public abstract void UpdateDirection();


        //<summay>
        //  Each kind of space ship will have their own skills
        //</summary>
        public abstract void UpdateSkills();


        
    }
}
