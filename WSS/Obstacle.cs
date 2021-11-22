using SplashKitSDK;

namespace spaces
{
    public abstract class Obstacle : GameObjects, IObMove
    {
        public Obstacle(float x, float y) : base(x, y)
        {
        }
        //<summay>
        //  Movement for Obstacle
        //</summary>

        public void Move(float speed)
        {
            SplashKit.SpriteSetY(ObjectSprite, SplashKit.SpriteY(ObjectSprite) + speed);

        }
        //<summay>
        //  Effect when collise with spaceship
        //</summary>
        public abstract void Effect(SpaceShip s);
    }
}
