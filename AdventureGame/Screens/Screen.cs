using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    public abstract class Screen
    {
        public List<string> ValidOptions { get; set; }
        public virtual void Show()
        {

        }
        public virtual void Navigate(int input)
        {
        }
    }
}
