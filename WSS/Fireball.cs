using SplashKitSDK;

namespace spaces
{
    public class Fireball : Obstacle
    {
        public Fireball(float x, float y) : base(x, y)
        {
            Image = SplashKit.LoadBitmap("fireball", "Fireball.png");
            ObjectSprite = new Sprite(Image);
            SplashKit.SpriteSetX(ObjectSprite, x);
            SplashKit.SpriteSetY(ObjectSprite, y);
        }


        public override void Effect(SpaceShip s)
        {
            s.Hearts = 0;
        }
    }
}
