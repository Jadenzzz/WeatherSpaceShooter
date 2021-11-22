using SplashKitSDK;

namespace spaces
{
    public class Burger : Obstacle
    {
        public Burger(float x, float y) : base(x, y)
        {
            Image = SplashKit.LoadBitmap("burger", "burger.png");
            ObjectSprite = new Sprite(Image);
            SplashKit.SpriteSetX(ObjectSprite, x);
            SplashKit.SpriteSetY(ObjectSprite, y);
        }

        //Effect when collise with spaceship
        public override void Effect(SpaceShip s)
        {
           
                s.Hearts = s.Hearts - 1;
            
        }
    }
}
