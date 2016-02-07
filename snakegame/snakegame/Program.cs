using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace snakegame
{
    public class Drawer // создаем класс дроуер,делаем его паблик чтобы был доступ из вне
    {
        public ConsoleColor color; // паблик свет
        public char sign; 
        public List<Point> body = new List<Point>(); 

        public Drawer() { }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);

            }
        }

        public void Save()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
