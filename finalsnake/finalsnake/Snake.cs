using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalsnake
{
    [Serializable]
    class Snake: Drawer 
    {
        public static int score = 0; // create the param for calculation the scores
        public Snake()
        {
            color = ConsoleColor.Green;
            sign = '0';
            body.Add(new Point(15, 15));

        }
        public void move(int dx, int dy) // function for movement of the snake
        {
            for ( int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x; // every next element will take the information fron the previous 
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx; // head takes the direction by the coordinates
            body[0].y += dy;

            if (body[0].x == 1) Game.EndGame; // game over if the snake goes out of the parametors
            if (body[0].y == 1) Game.EndGame;
            if (body[0].x == 99) Game.EndGame;
            if (body[0].x == 99) Game.EndGame;
            
            if (SnakeinSnake()= true) // game over, if the snake crashes by inself
            {
                Game.EndGame;
            }
            if (body[0].x == Game.food.body[0].x && body[0].y == Game.food.body[0].y) // check if the snake eats the food
            {
                body.Add(new Point(0, 0)); // if the snake eats the food it moves to the other place

                Game.food.SetNewPosition();
                while (Food.FoodinSnake() == true)
                {
                    Game.food.SetNewPosition();
                }
                score++; // add scores  

                if (score % 4 == 0)// after every 4th score game jumps to next level
                {
                    Game.level++;
                    Game.snake.body.Clear(); // snake becomes as in the beginning 
                    SnakeNewPosition();
                }

            }
        }
        public static void SnakeNewPosition() 
        {
            Game.snake.body.Clear();
            Random r = new Random();
            Game.snake.body.Add(new Point(r.Next(3, 49), r.Next(6, 29)));

        }
        public static bool SnakeinSnake() // check if the snake ate the food
        {
            for (int i = 1; i < Game.snake.body.Count; i++)
            {
                if (Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                    return true;
            }
            return false;
        }
    }
 }