using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using System.IO;
namespace spaces
{
    public class Playing : GameState
    {
        public Playing(SpaceShip ship)
        {
            Weather.getInstance().getWeather();
            s = ship;
        }
        Bitmap background = SplashKit.LoadBitmap("background", "bg3.jpg");
        Bitmap clear = SplashKit.LoadBitmap("clear", "clear.jpg");
        Bitmap cloud = SplashKit.LoadBitmap("cloud", "cloudy.jpg");
        Bitmap snow = SplashKit.LoadBitmap("snow", "snow.jpg");
        Bitmap rain = SplashKit.LoadBitmap("rain", "rain.jpg");
        GameMain g = new GameMain();
        public static SpaceShip s;
        public override void Update(SpaceShooter f)
        {
            if (s.Hearts > 0)
            {

                SplashKit.HideMouse();
                switch (Weather.getInstance().Cond)
                {
                       case "Clear": SplashKit.DrawBitmap(clear, 0, 0); break;
                       case "Clouds": SplashKit.DrawBitmap(cloud, 0, 0); break;
                       case "Rain": SplashKit.DrawBitmap(rain, 0, 0); break;
                       case "Snow": SplashKit.DrawBitmap(snow, 0, 0); break;
                       default: SplashKit.DrawBitmap(background, 0, 0); break;
                }

                SplashKit.DrawText("Hearts: " + s.Hearts, Color.Red, 5, 10);
                SplashKit.DrawText("Score: " + s.Score, Color.Red, 5, 30);
                SplashKit.DrawText("You're in: " + Weather.getInstance().city, Color.Yellow, 5, 50);
                SplashKit.DrawText("Weather condition: " + Weather.getInstance().Cond, Color.Yellow, 5, 70);
                SplashKit.DrawText("Temperature: " + Weather.getInstance().Temp, Color.Yellow, 5, 90);
                s.UpdateDirection();
                s.Draw();
                s.UpdateMove();
                s.UpdateSkills();
                
                g.DrawObject();
                g.AddObject();
                g.AddFire(s);
                g.MoveObject();
                g.Collision(s);
                if (s.Hearts < 0)
                {
                    s.Alive = false;
                }
                g.Check();
                g.RemoveObject();


                SplashKit.RefreshScreen(60);

            }
           
        }
        public override void ChangeState(SpaceShooter f)
        {
            if(s.Hearts <= 0)
            {
                f.NextState(new GameOver());
            }

        }

    }
}
