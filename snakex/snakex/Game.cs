using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace snakex
{
    class Game
    {
        public static Food food = new Food();
        public static Snake snake = new Snake();
        public static bool GameOver = false;
        public static Wall wall = new Wall(1);
        //public static int level = 1;
        public Game()
        {
            Init();
            Play();
        }
        public void Init()
        {
           // Console.SetWindowSize(51, 51);
            food.NewRandomPosition();
            snake.body.Add(new Point(10, 10));
        }
        
        public void Play()
        {
            while (!GameOver)
            {
                Draw(); // draw the  snake or food
                ConsoleKeyInfo button = Console.ReadKey();

                if (button.Key == ConsoleKey.UpArrow)
                    snake.move(0, -1);
                if (button.Key == ConsoleKey.DownArrow)
                    snake.move(0, 1);
                if (button.Key == ConsoleKey.LeftArrow)
                    snake.move(-1, 0);
                if (button.Key == ConsoleKey.RightArrow)
                    snake.move(1, 0);
                if (button.Key == ConsoleKey.F2)
                    Save();
                if (button.Key == ConsoleKey.F3)
                    Resume();
             }
            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAMEOVER:C");
            Console.ReadKey();

        }
        public static void Draw()
        {
            Console.Clear();
            snake.Draw();
            food.Draw();
            wall.Draw();
        }
        public void Save()
        {
            snake.Save();
            food.Save();
            wall.Save();
        }
        public void Resume()
        {
            snake.Resume();
            food.Resume();
            wall.Resume();
        }
    }

}
