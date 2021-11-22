using SplashKitSDK;

namespace spaces
{
    public class GameObjects
    {
        private Sprite _sprite;
        private bool _alive;
        private Bitmap _image;
       
        public float X { get { return SplashKit.SpriteX(_sprite); }  set { SplashKit.SpriteSetX(_sprite, value); } }

        public float Y { get { return SplashKit.SpriteY(_sprite); } set { SplashKit.SpriteSetY(_sprite, value); } }

        public float Width { get { return SplashKit.SpriteWidth(_sprite); } }

        public float Height { get { return SplashKit.SpriteHeight(_sprite); } }

        public bool Alive { get { return _alive; } set { _alive = value; } }

        public Bitmap Image { get { return _image; } set { _image = value; } }


        public Sprite ObjectSprite { get { return _sprite; } set { _sprite = value; } }

   
        

        public GameObjects(float x, float y)
        {
            Alive = true;
        }

        public GameObjects()
        {
            Alive = true;
        }

        public virtual void Draw()
        {
            SplashKit.DrawSprite(_sprite);
        }
        public bool IsCollision(GameObjects obj)
        {
            return (SplashKit.SpriteCollision(ObjectSprite, obj.ObjectSprite));
        }
    }
}
