using SplashKitSDK;

namespace spaces
{
    public class Heart : Obstacle
    {

        public Heart(float x, float y) : base(x, y)
        {
            Image = SplashKit.LoadBitmap("heart", "heart.png");
            ObjectSprite = new Sprite(Image);
            SplashKit.SpriteSetX(ObjectSprite, x);
            SplashKit.SpriteSetY(ObjectSprite, y);
        }

        //Effect when collide with spaceship
        public override void Effect(SpaceShip s)
        {

            s.Hearts += 1;
        }
    }
}
