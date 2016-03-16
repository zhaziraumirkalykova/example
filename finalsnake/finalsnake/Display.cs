using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalsnake
{
    class Display
    {
        public static void display()
        {
            Console.SetCursorPosition(5, 5);
            Console.Write("SCORE:" + "                " + "Level:" + Game.level);
        }
    }
}
