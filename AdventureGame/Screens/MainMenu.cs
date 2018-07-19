using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    public class MainMenu:Screen
    {
        public MainMenu()
        {
            AddOptions();
            RunScreen();
        }
        private void RunScreen()
        {
            int input = 0;
            Show();
            input = InputController.HandleInput(this);
            Navigate(input);
        }
        private void AddOptions()
        {
            ValidOptions = new List<string>();
            ValidOptions.Add("1");
            ValidOptions.Add("2");
            ValidOptions.Add("3");
        }
        public override void Show()
        {
            Console.WriteLine("Adventure Game");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Exit");
        }
        public override void Navigate(int input)
        {
            Console.Clear();
            if (input == 1) ScreenController.currentScreen = new NewGame();
            else if (input == 2) ScreenController.currentScreen = new LoadGame();
            else if (input == 3) Environment.Exit(0);
        }
    }
}
