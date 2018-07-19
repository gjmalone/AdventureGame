using AdventureGame.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Static
{
    public static class ScreenController
    {
        public static Screen currentScreen;
        public static Screen previousScreen;
        public static void Init()
        {
            currentScreen = new MainMenu();
        }
    }
}
