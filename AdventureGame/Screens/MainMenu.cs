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
        Decision mainMenu;
        public MainMenu()
        {
            ScreenController.Clear();
            AddDecisions();
            Run();
        }
        private void Run()
        {
            ScreenController.Write("Adventure Game");
            ShowMenuOptions();
        }
        private void AddDecisions()
        {
            mainMenu = new Decision("What Would You Like To Do?", new List<string>() { "1. New Game", "2. Load Game", "3. Exit" });
        }
        private void ShowMenuOptions()
        {
            int input = mainMenu.Run();
            Navigate(input);
        }
        private void Navigate(int input)
        {
            Console.Clear();
            if (input == 1) ScreenController.currentScreen = new NewGame();
            else if (input == 2) ScreenController.currentScreen = new LoadGame();
            else if (input == 3) Environment.Exit(0);
        }
    }
}
