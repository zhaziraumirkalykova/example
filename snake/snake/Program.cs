using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        public static snake dragon = new snake();
        public static int sizex = 60, sizey = 60;
        public wall Wall = new wall();
        public food Food = new food();
        static void Main(string[] args)
        {
            Console.SetWindowSize(sizex, sizey);
            Console.SetCursorPosition(1, 1);
            dragon = new snake(1, 1);
            for(int i = 0; i < 5; ++i)
            {
                int x = () % sizex, y = getrand() % sizey;
                Food.add(x, y);
            }
            for(int i = 0; i < 20; ++i)
            {
                int x = getrand() % sizex, y = getrand() % sizey;
                if (x == 1 && y == 1) continue;
                Wall.add(x, y);
            }
        }
    }
}
