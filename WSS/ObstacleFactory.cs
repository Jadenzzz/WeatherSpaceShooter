using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using System.Collections;


namespace spaces
{
    //Factory pattern
    public class ObstacleFactory
    {
        private static ObstacleFactory instance;

        public static ObstacleFactory getInstance()
        {
            if (instance == null)
                instance = new ObstacleFactory();
            return instance;
        }

        private ObstacleFactory()
        {

        }
        
        public IObMove GetObstacles(string key)
        {
            switch (key)
            {
                case "burger":
                    return new Burger(SplashKit.Rnd(0, 500), 0);
                case "stone":
                    return new Stone(SplashKit.Rnd(0, 500), 0);
                case "fireball":
                    return new Fireball(SplashKit.Rnd(0, 500), 0);
                case "heart":
                    return new Heart(SplashKit.Rnd(0, 500), 0);
                default:
                    return null;
            }
        }
        public IObMove GetFire(float x, float y)
        {
            return new Fire(x, y);
        }
    }
}


    
