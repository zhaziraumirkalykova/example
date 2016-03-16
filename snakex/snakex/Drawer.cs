using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snakex
{
    public class Drawer
    {
        public ConsoleColor color;
        public string sign;
        public List<Point> body = new List<Point>();
        
        public Drawer () {  }
         
        public virtual void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);

            }
        }

    }
}
