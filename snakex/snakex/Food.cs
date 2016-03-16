using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakex
{
    public class Food : Drawer
    {
        public Food()
        {
            color = ConsoleColor.Red;
            sign = "$";
        }
        public void NewRandomPosition()
        {
            int x = 0;
            int y = 0;
           // bool gameOver = false;
            //while (!gameOver)
            {
                x = new Random().Next() % 50;
                y = new Random().Next() % 50;
                //  gameOver = true;
                //for (int i = 0; i< Game.wall.body.Count-1; i++)
                if (body.Count == 0)
                    body.Add(new Point(x, y));
                else
                {
                    body[0].x = x;
                    body[0].y = y;
                }
            }
        }
    }
}
