using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    public class Decision
    {
        public List<string> Options {get;}
        public List<string> ValidResponses { get;}
        public string Question { get;}

        public Decision(string question,List<string>options)
        {
            Question = question;
            Options = options;
            ValidResponses = new List<string>();
            Options.ForEach(x =>
            {
                ValidResponses.Add(x[0].ToString());
            });
        }
        public int Run()
        {
            Display();
            return HandleInput();
        }
        private void Display()
        {
            Console.WriteLine(Question);
            Options.ForEach(x => Console.WriteLine(x));
        }
        private int HandleInput()
        {
            int ret = 0;
            bool success = false;
            while (success == false)
            {
                var result = Console.ReadLine();
                ValidResponses.ForEach(x =>
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
                    ScreenController.Redo();
                    Display();
                }
            }
            return ret;
        }
    }
}
