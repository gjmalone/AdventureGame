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
        public static List<string> shownScreenText;
        public static void Init()
        {
            shownScreenText = new List<string>();
            currentScreen = new MainMenu();
        }
        public static void Write(string screenText)
        {
            shownScreenText.Add(screenText);
            Console.WriteLine(screenText);
        }
        public static void Redo()
        {
            shownScreenText.ForEach(x => Console.WriteLine(x));
        }
        public static void Clear()
        {
            Console.Clear();
            shownScreenText.Clear();
        }
    }
}
