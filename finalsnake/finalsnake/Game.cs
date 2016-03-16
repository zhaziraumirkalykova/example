using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalsnake
{
    class Game
    {
        public static Food food = new Food(); // create the samples of the classes
        public static Snake snake = new Snake();
        public static bool GameOver = false;
        public static int level = 1;
        public Game()
        {
            Init();
            Play();
        }
        public void Init() // function initalization 
        {
            Console.SetWindowSize(100, 100);
            food.SetNewPosition(); // in the random place occures the food
            while (Food.FoodinSnake() == true)
            {
                food.SetNewPosition();
            }
             
        }
        public void Play()
        {
            while (!GameOver) 
            {
                Draw(); // draw the snake food 
                ConsoleKeyInfo button = Console.ReadKey(); // read the buttons by walk
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
        }
        public static void EndGame()
        {
            Console.Clear();
            Console.SetCursorPosition(16, 13);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over :)");
            Console.SetCursorPosition(10,15);
            Console.WriteLine("Try again ;)");
            snake.body.Clear();
            Snake.SnakeNewPosition();
            Console.ReadKey();
        }
        public static void Draw()
        {
            Console.Clear();
            Display.display();
            snake.Draw();
            food.Draw();
        }
       public void Save()
        {
            snake.Save();
            food.Save();
        }
        public void Resume()
        {
            snake.Resume();
            food.Resume();
        }
    }
}
