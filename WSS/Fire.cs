using SplashKitSDK;

namespace spaces
{
    public class Fire : GameObjects, IObMove
    {
        public IFireState _state; //state according to direction of space ship
        public Fire(float x, float y) : base(x, y)
        {
            Image = SplashKit.LoadBitmap("fire", "Fire.png");
            _state = new FireUp();
            _state.ChangeState(this);
            _state.UpdateImage(this);
            ObjectSprite = new Sprite(Image);
            SplashKit.SpriteSetX(ObjectSprite, x);
            SplashKit.SpriteSetY(ObjectSprite, y);
        }
        //Movement for Fire
        public void Move(float speed)
        {
            _state.UpdateMove(this, speed);

        }


        

        public void NextState(IFireState state)
        {
            _state = state;
        }
    }
}
