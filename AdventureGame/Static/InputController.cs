using AdventureGame.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Static
{
    public static class InputController
    {
        public static int HandleInput(Screen screen)
        {
            int ret = 0;
            bool success = false;
            while (success == false)
            {
                var result = Console.ReadLine();
                screen.ValidOptions.ForEach(x =>
                {
                    if (x == result)
                    {
                        ret = Convert.ToInt16(x);
                        success = true;
                    };
                });
                if (!success)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Entry. Try Again.");
                    screen.Show();
                }
            }
            return ret;
        }
    }
}
