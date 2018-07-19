using AdventureGame.Screens;
using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class AdventureGame
    {
        public AdventureGame()
        {
            Start();
        }
        private void Start()
        {
            ScreenController.Init();
        }
        private void NewGame()
        {
            Console.Clear();
            Console.WriteLine("New Game");
            Console.ReadLine();
        }
        private void LoadGame()
        {
            Console.Clear();
            Console.WriteLine("Load Game");
            Console.ReadLine();
        }
    }
}
