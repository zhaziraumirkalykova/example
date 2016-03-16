using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    [Serializable]
    class Snake: Drawer
    {
        
        public static int score = 0;// create the parametor which calculates the scores
        public Snake()
        {
            color = ConsoleColor.Green;
            sign = '*';
            body.Add(new Point(10, 10));
           
        }
 
    
        public void move(int dx, int dy)// function allows the snake's movement
        {
            for (int i = body.Count - 1; i > 0; i--)
            { 
                body[i].x = body[i - 1].x;// every next element will have the data of the previous
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;// head move by the coordinates
            body[0].y += dy;

            if (body[0].x == -1) Game.EndGame(); // game over if the snake goes out of the window
            if (body[0].y == 3) Game.EndGame();
            if (body[0].x == 50) Game.EndGame();
            if (body[0].y == 30) Game.EndGame();
        
            if (SnakeinSnake() == true)// game over if snake faces with itself
            {
                Game.EndGame();
            }
            if (body[0].x == Game.food.body[0].x &&// check if the snake eats the food
                body[0].y == Game.food.body[0].y)
            {
                body.Add(new Point(0, 0));// if is s the snake move into other place
                

                Game.food.SetNewPosition();
                while(Food.FoodinSnake() == true)
                {
                    Game.food.SetNewPosition();
                }
                score++; 

                if (score % 4 == 0)// if it gets 4th pozition than i goes to the next level
                {
                    Game.level++;
                    Game.snake.body.Clear(); 
                    SnakeNewPosition();
                }

            }
        }
        public static void SnakeNewPosition() // New position
        {
            Game.snake.body.Clear();
            Random r = new Random();
            Game.snake.body.Add(new Point(r.Next(3, 49), r.Next(6, 29)));

        }
        public static bool SnakeinSnake()    
        {
            for( int i=1; i<Game.snake.body.Count; i++)
            {
                if (Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                    return true;               
            }
            return false;
        }   
    }
}
