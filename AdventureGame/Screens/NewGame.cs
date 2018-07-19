using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    public class NewGame:Screen
    {
        public NewGame()
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
        }
        public override void Show()
        {
            Console.WriteLine("New Game");
            Console.WriteLine("1. Exit");
        }
        public override void Navigate(int input)
        {
            Console.Clear();
            if (input == 1) Environment.Exit(0);
        }
    }
}
