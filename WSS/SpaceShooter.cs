using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace spaces
{
    public class SpaceShooter
    {
        public IState _state;
        public SpaceShooter()
        {
            _state = new MainMenu();
        }
         public void NextState(IState state)
        {
            _state = state;
        }
        
        public void run()
        {
            new Window("Space Shooter", 400, 600);
            while (!SplashKit.WindowCloseRequested("Space Shooter"))
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                _state.Update(this);
                _state.ChangeState(this);

                SplashKit.RefreshScreen(60);
            }
        }
    }
}
