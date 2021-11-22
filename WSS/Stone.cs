using SplashKitSDK;

namespace spaces
{
    public class Stone : Obstacle
    {
        
        public Stone(float x, float y) : base(x, y)
        {
            Image = SplashKit.LoadBitmap("stone", "stone.png");
            ObjectSprite = new Sprite(Image);
            SplashKit.SpriteSetX(ObjectSprite, x);
            SplashKit.SpriteSetY(ObjectSprite, y);
        }
        //Effect when collise with spaceship
        public override void Effect(SpaceShip s)
        {
            s.Hearts = s.Hearts - 3;
        }
    }
}
