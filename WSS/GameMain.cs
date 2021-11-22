using System.Collections.Generic;
using SplashKitSDK;


namespace spaces
{
    public class GameMain
    {
        private List<IObMove> ObjectMove;
        private List<IObMove> Delete;

        
        public GameMain()
        {
            ObjectMove = new List<IObMove>();
            Delete = new List<IObMove>();
        }

        
        //Remove objects in Delete list
        public void RemoveObject()
        {
            foreach (IObMove obj in Delete)
            {
                ObjectMove.Remove(obj);
            }
        }
        //Add Fire and Obstacle from factory list to ObjectMove list
        public void AddObject()
        {
            string[] s = new string[] { "burger", "stone", "heart", "fireball" };
            for (int i = 0; i < s.Length; i++)
            {
                if (SplashKit.Rnd(0, 1000) % 100 == 0)
                {
                    IObMove obs = ObstacleFactory.getInstance().GetObstacles(s[i]);
                    ObjectMove.Add(obs);
                }
            }
        }

        //Implement movement for game objects
        public void MoveObject()
        {
            foreach (IObMove obj in ObjectMove)
            {
                if (obj.GetType() != typeof(Fire))
                {
                    obj.Move(3f);
                }
                if (obj.GetType() == typeof(Fire))
                {
                    obj.Move(10f);
                }
            }
        }
        //Draw the objects
        public void DrawObject()
        {
            foreach (GameObjects obj in ObjectMove)
            {
                obj.Draw();
                
            }
        }

        //Effect when each object collide with each others
        public void Collision(SpaceShip s)
        {
            foreach (GameObjects obj in ObjectMove)
            {
                if (obj is Obstacle)
                {
                    Obstacle ob = obj as Obstacle;
                    if (ob.IsCollision(s) && s.shield == false)
                    {
                        SplashKit.PlaySoundEffect("expl.wav");
                        ob.Effect(s);
                        Delete.Add(ob);
                    }
                    else if (ob.IsCollision(s) && s.shield == true)
                    {
                        SplashKit.PlaySoundEffect("expl.wav");
                        if (ob.GetType() == typeof(Fireball))
                        {
                            ob.Effect(s);
                            Delete.Add(ob);
                        }
                        else
                        {
                            Delete.Add(ob);
                        }
                    }
                    foreach (IObMove f in ObjectMove)
                    {
                        if (f is Fire)
                        {
                            Fire fi = f as Fire;
                            if (fi.IsCollision(ob) && ob.GetType() != typeof(Heart))
                            {
                                SplashKit.PlaySoundEffect("expl.wav");
                                Delete.Add(ob);
                                s.Score += 1;
                            }
                        }

                    }
                }
            }
           
        }
        
        public void AddFire(SpaceShip s)
        {
            if (SplashKit.KeyTyped(KeyCode.SpaceKey))
            {
                SplashKit.PlaySoundEffect("pew.wav");
                if (s.threeshot == false)
                {
                    if (Dir.dir == Direction.Up || Dir.dir == Direction.Down)
                    {
                        Fire b = new(SplashKit.MouseX() - 8, SplashKit.MouseY() - s.Height / 2);
                        ObjectMove.Add(b);
                    }

                    if (Dir.dir == Direction.Left || Dir.dir == Direction.Right)
                    {
                        Fire b = new(SplashKit.MouseX() - s.Width / 2, SplashKit.MouseY() - 8);
                        ObjectMove.Add(b);
                    }
                }
                if (s.threeshot == true)
                {
                    for (int i = 1; i < 4; i++)
                    {
                        if (Dir.dir == Direction.Up || Dir.dir == Direction.Down)
                        {
                            Fire b = new(SplashKit.MouseX() - s.Width / 2 + 15 - 68 + 34 * i, SplashKit.MouseY() - s.Height / 2);
                            ObjectMove.Add(b); ;
                        }
                        if (Dir.dir == Direction.Left || Dir.dir == Direction.Right)
                        {
                            Fire b = new(SplashKit.MouseX() - s.Width / 2, SplashKit.MouseY() - s.Height / 2 + 15 - 68 + 34 * i);
                            ObjectMove.Add(b);
                        }
                    }
                }
            }

        }
        //Check whether the objects fall outside the window screen or not, if yes delete it
        public void Check()
        {
            foreach (IObMove obj in ObjectMove)
            {
                if (obj.Y < 0 || obj.Y > SplashKit.ScreenHeight())
                {
                    Delete.Add(obj);
                }
                if (obj is Fire)
                {
                    Fire fi = obj as Fire;
                    if (fi.Y < 0 || fi.Y > SplashKit.ScreenHeight() || fi.X < 0 || fi.X > SplashKit.ScreenWidth())
                    {
                        Delete.Add(fi);
                    }

                }
            }
        } 
    }
}
